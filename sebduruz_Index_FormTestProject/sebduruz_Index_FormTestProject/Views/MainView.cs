/// ETML
/// Autor : Sébastien Duruz
/// Date : 12.03.2021
/// Description : The main view of the application

using sebduruz_Index_FormTestProject.Controllers;
using sebduruz_Index_FormTestProject.Models.ObjectsIndex;
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
        public List<IObjectsIndex> Results { get; set; }
        public List<IObjectsIndex> FilteredResults { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainView()
        {
            InitializeComponent();
            this.Results = new List<IObjectsIndex>();
            this.FilteredResults = new List<IObjectsIndex>();
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
                this.ShowMessageBox("Aucun résultats, veuillez contrôler votre saisie.");
            }
        }

        /// <summary>
        /// Print Results content onto the Interface
        /// </summary>
        private void PrintResultsContent()
        {
            //Reset the output list before doing anything
            ResetOutputList();

            //If filteredResult list empty print result list, else print filteredResult list
            if (this.FilteredResults.Count == 0)
            {
                //Print the results
                foreach (IObjectsIndex result in this.Results)
                {
                    this.outputListBox.Items.Add(new ListViewItem(new string[]{result.Type, result.Name, result.Path}));
                }

                //Print numbers of results
                this.nbOfResultsLabel.Text = $"Nombres de résultats : [{this.Results.Count}]";
            }
            else
            {
                this.cancelButton.Visible = true;

                //Print the results with filters
                foreach (IObjectsIndex filteredResult in this.FilteredResults)
                {
                    this.outputListBox.Items.Add(new ListViewItem(new string[] { filteredResult.Type, filteredResult.Name, filteredResult.Path }));
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
                    using (StreamWriter writer = File.CreateText($"{fileDialog.FileName}")) 
                    {
                        foreach(ListViewItem result in this.outputListBox.Items)
                        {
                            writer.WriteLine($"{result.SubItems[0].Text} | {result.SubItems[1].Text} | {result.SubItems[2].Text}");
                        }
                    };   
                }
                catch
                {
                    ShowMessageBox("Le fichier choisi n'a pas pu être ouvert. Veuillez verifier que celui-ci ne soit pas utilisé par un autre processus et réessayer.");
                }
            }
        }

        /// <summary>
        /// Open system file explorer, let user select source folder
        /// </summary>
        private void OpenFolderPictureBox_Click(object sender, System.EventArgs e)
        {
            //Open File dialog to user
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                FileName = "Dossier source"
            };

            // User press OK, set path to the path textbox
            if (fileDialog.ShowDialog() == DialogResult.OK)
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

            //Check each filters
            foreach(string filter in filters)
            {
                //if filter is not empty space
                if(filter.Trim(' ') != "")
                {
                    // Check all objects in Results list
                    foreach (IObjectsIndex result in Results)
                    {
                        //The name contains and not alrealy inside filtered list
                        if(result.Name.Contains(filter) && !this.FilteredResults.Contains(result))
                        {
                            this.FilteredResults.Add(result);
                        }
                    }
                }
            }

            //Print the results
            this.PrintResultsContent();

            //Nothing as been found
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

        /// <summary>
        /// Switch the ability to access File explorer
        /// </summary>
        private void FilesRadio_CheckedChanged(object sender, System.EventArgs e)
        {
            if(this.filesRadio.Checked)
            {
                this.openFolderPictureBox.Enabled = true;
            }
            else
            {
                this.openFolderPictureBox.Enabled = false;
            }
        }

        /// <summary>
        /// Empty and reset settings of the output box
        /// </summary>
        private void ResetOutputList()
        {
            this.outputListBox.Clear();
            this.outputListBox.Columns.Add("Type", 50);
            this.outputListBox.Columns.Add("Nom", 250);
            this.outputListBox.Columns.Add("Source", 400);
            this.outputListBox.AllowColumnReorder = true;
        }
    }
}
