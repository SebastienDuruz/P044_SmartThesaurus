/// ETML
/// Autor : Sébastien Duruz
/// Date : 12.03.2021
/// Description : The main view of the application

using sebduruz_Index_FormTestProject.Controllers;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace sebduruz_Index_FormTestProject
{
    public partial class MainView : Form
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public Controller Ctrler { get; set; }
        public List<string> Results { get; set; }
        public List<string> FilteredResults { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainView()
        {
            InitializeComponent();
            this.Results = new List<string>();
            this.FilteredResults = new List<string>();
            this.toolTip.SetToolTip(this.pathLabel, @"Veuillez entrer un chemin d'accès ou une page web. (Exemples [C:\Users\USERNAME\Documents] [https://fr.wikipedia.org/])  ");
        }

        /// <summary>
        /// Execute the indexation when exec button clicked
        /// </summary>
        private void ExecButton(object sender, System.EventArgs e)
        {
            //Before all search set clear the necessary datas
            this.Results.Clear();
            this.FilteredResults.Clear();
            this.cancelButton.Visible = false;

            //File indexation
            if(this.filesRadio.Checked)
            {
                this.Results = this.Ctrler.GetFilesFromIndexation(pathTextBox.Text);
            }
            //Web page scraper (extract links from page)
            else
            {
                this.Results = this.Ctrler.GetLinksFromWebScraper(pathTextBox.Text);
            }

            //Print the results if something as been returned
            if(this.Results != null && this.Results.Count > 0)
            {
                this.PrintResultsContent();
            }
            //If nothing returned show error message to user
            else
            {
                this.ShowMessageBox("Aucun résultats, veuillez contrôler votre saisie. Le dossier est il vide ?");
            }
        }

        /// <summary>
        /// Print Results content onto the Interface
        /// </summary>
        private void PrintResultsContent()
        {
            //Clear the content
            this.outputBox.Text = "";

            //If filteredResult list empty print result list, else print filteredResult list
            if(this.FilteredResults.Count == 0)
            {
                //Print the results
                foreach (string result in this.Results)
                {
                    this.outputBox.Text += $"{result}\n";
                }

                //Print numbers of results
                this.nbOfResultsLabel.Text = $"Nombres de résultats : [{this.Results.Count}]";
            }
            else
            {
                this.cancelButton.Visible = true;

                //Print the results with filters
                foreach (string filteredResult in this.FilteredResults)
                {
                    this.outputBox.Text += $"{filteredResult}\n";
                }

                //Print numbers of results after filters applied
                this.nbOfResultsLabel.Text = $"Nombres de résultats : [{this.FilteredResults.Count}]";
            }
        }

        /// <summary>
        /// Show MessageBox to user
        /// </summary>
        /// <param name="message">The message to show</param>
        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        /// <summary>
        /// Exit the application from the context menu
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Export the results actually showed to user
        /// </summary>
        private void ExportDatasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Open SaveFileDialog to user
            SaveFileDialog fileDialog = new SaveFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt",
                DefaultExt = "txt",
                Title = "Choisissez la destination de l'exportation",
            };

            //User press OK, try to write the file
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Open (create if needed) the file and write Results into it. Always .txt file
                    using (StreamWriter writer = File.CreateText($"{fileDialog.FileName}.{fileDialog.DefaultExt}")) 
                    { 
                        foreach(string result in this.Results)
                        {
                            writer.WriteLine(result);
                        }
                    };   
                }
                catch
                {
                    ShowMessageBox("Le fichier choisi n'a pas pu être ouvert. Veuillez verifier que celui-ci ne soit pas ouvert puis réessayer.");
                }
            }
        }

        /// <summary>
        /// Open system file explorer, let user select source folder
        /// </summary>
        private void OpenFolderPictureBox_Click(object sender, System.EventArgs e)
        {
            //Open File dialog to user
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.ValidateNames = false;
            fileDialog.CheckFileExists = false;
            fileDialog.CheckPathExists = true;
            fileDialog.FileName = "Dossier source";

            // User press OK, set path to the path textbox
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pathTextBox.Text = Path.GetDirectoryName(fileDialog.FileName);
            }
        }

        /// <summary>
        /// Apply filter to results (use of multiples parameters with ;)
        /// </summary>
        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            //Get filters splited
            string[] filters = this.Ctrler.SplitFilters(this.filtersTextBox.Text);
            
            //Clear the actual list and add to filtered results if match found
            this.FilteredResults.Clear();
            foreach(string filter in filters)
            {
                //if filter is not empty space
                if(filter.Trim(' ') != "")
                {
                    foreach (string result in Results)
                    {
                        //The result string contains the filter and not alrealy inside filtered list, add it to lists
                        if (result.Contains(filter) && this.FilteredResults.Contains(result) == false)
                        {
                            this.FilteredResults.Add(result);
                        }
                    }
                }
            }

            //Print the results
            this.PrintResultsContent();

            if(this.FilteredResults.Count == 0)
            {
                this.ShowMessageBox("Aucun résultat n'a été trouvé avec ces filtres.");
            }
        }

        /// <summary>
        /// Remove the applied filters
        /// </summary>
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            // Clear FiltersResults and print unfiltered results
            this.FilteredResults.Clear();
            this.PrintResultsContent();

            // Hide cancel button
            this.cancelButton.Visible = false;
        }
    }
}
