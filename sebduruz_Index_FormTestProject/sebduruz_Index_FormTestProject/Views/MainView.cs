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

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainView()
        {
            InitializeComponent();
            this.Results = new List<string>();
        }

        /// <summary>
        /// Execute the indexation when exec button clicked
        /// </summary>
        private void ExecButton(object sender, System.EventArgs e)
        {
            //Before all search set a new instance
            this.Results = new List<string>();

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
                this.ShowMessageBox("Aucun resultats, veuillez contrôler votre saisie.");
            }
        }

        /// <summary>
        /// Print Results content onto the Interface
        /// </summary>
        private void PrintResultsContent()
        {
            //Clear the content
            this.outputBox.Text = "";

            //Print the results
            foreach(string result in this.Results)
            {
                this.outputBox.Text += $"{result}\n";
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
    }
}
