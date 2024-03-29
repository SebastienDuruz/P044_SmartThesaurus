﻿/// ETML
/// Autor : Sébastien Duruz
/// Date : 08.05.2021
/// Description : The main view of the application

using P044_SmartThesaurus.AppBusiness;
using P044_SmartThesaurus.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace P044_SmartThesaurus
{
    /// <summary>
    /// Class MainView
    /// </summary>
    public partial class MainView : Form
    {
        /// <summary>
        /// Enum : The possible type of indexed objects
        /// </summary>
        enum ObjectType
        {
            Dossier,
            Fichier,
            Lien,
            Image
        }

        /// <summary>
        /// Class Properties
        /// </summary>
        public MainController Ctrler { get; set; }
        private List<IndexedObject> Results { get; set; }
        private List<IndexedObject> FilteredResults { get; set; }
        private ImageList IconsList { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainView()
        {
            InitializeComponent();
            this.Results = new List<IndexedObject>();
            this.FilteredResults = new List<IndexedObject>();
            this.toolTip.SetToolTip(this.pathLabel, @"Veuillez entrer un chemin d'accès ou une page web. (Exemples [C:\Users\USERNAME\Documents] [https://fr.wikipedia.org/])  ");
            this.toolTip.SetToolTip(this.filterHelpPictureBox, "Combiner les filtres avec l'ajout du caractère [:] entre chaque filtre\n Nouveau filtres avec l'ajout du caractère [|]");
            this.toolTip.SetToolTip(this.bookmarkHelpIcon, "Pour ajouter un favoris cliquer sur l'étoile ou directement depuis le menu favoris-->ajouter.");
            this.GetImagesFromResource();

            // Add event to read user keys
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(UserKeyPressed);
        }

        /// <summary>
        /// Execute the indexation when exec button clicked
        /// </summary>
        private void ExecuteButtonClick(object sender, EventArgs e)
        {
            //Before all search set clear the necessary datas
            this.Results.Clear();
            this.FilteredResults.Clear();
            this.cancelButton.Visible = false;

            //File indexation
            if (this.filesRadio.Checked)
            {
                this.Results = this.Ctrler.GetFilesFromIndexation(pathTextBox.Text);
            }
            //Web page scraper (extract links from page)
            else
            {
                this.Results = this.Ctrler.GetLinksFromWebScraper(pathTextBox.Text);
            }

            //Print the results if something as been returned
            if (this.Results != null && this.Results.Count > 0)
            {
                this.PrintResultsContent();

                // Sleep 1sec just to be sure lastIndex text file is not used anymore
                Thread.Sleep(1000);

                // Path was valid, set it to lastIndex
                this.Ctrler.SetLastIndexed(this.pathTextBox.Text);
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
                this.ListBoxPrinter(this.Results);

                //Print numbers of results
                this.nbOfResultsLabel.Text = $"Nombres de résultats : [{this.Results.Count}]";
            }
            else
            {
                this.cancelButton.Visible = true;

                this.ListBoxPrinter(this.FilteredResults);

                //Print numbers of results after filters applied
                this.nbOfResultsLabel.Text = $"Nombres de résultats : [{this.FilteredResults.Count}]";
            }
        }

        /// <summary>
        /// Print IndexedOBject to outputBox
        /// </summary>
        /// <param name="results">The list to print</param>
        private void ListBoxPrinter(List<IndexedObject> results)
        {
            //Foreach objects in the list
            foreach (IndexedObject result in results)
            {
                // Get the type of object from Enum
                this.outputListBox.Items.Add(new ListViewItem(new string[] { result.Type, result.Name, result.Path }, (int)Enum.Parse(typeof(ObjectType), result.Type)));
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
        private void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Open the path with explorer
        /// </summary>
        private void OpenWithExplorer(object sender, EventArgs e)
        {
            if (this.outputListBox.SelectedItems.Count > 0)
            {
                // Open the path of the object or directly the object if the item is a folder or a link
                switch((ObjectType)Enum.Parse(typeof(ObjectType), this.outputListBox.SelectedItems[0].SubItems[0].Text))
                {
                    case ObjectType.Image:
                    case ObjectType.Fichier:
                        Process.Start("explorer.exe", this.outputListBox.SelectedItems[0].SubItems[2].Text);
                        break;
                    case ObjectType.Dossier:
                        Process.Start("explorer.exe", $@"{ this.outputListBox.SelectedItems[0].SubItems[2].Text}\{this.outputListBox.SelectedItems[0].SubItems[1].Text}");
                        break;
                    case ObjectType.Lien:
                        // Open link with web browser
                        Process.Start(this.outputListBox.SelectedItems[0].SubItems[1].Text);
                        break;
                }
            }
        }

        /// <summary>
        /// Export the results actually showed to user
        /// </summary>
        private void ExportDataButtonClick(object sender, EventArgs e)
        {
            //Open SaveFileDialog to user
            SaveFileDialog fileDialog = new SaveFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt",
                DefaultExt = "txt",
                Title = "Choisissez la destination de l'exportation",
            };

            //User press OK, try to write the file
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Open (create if needed) the file and write Results into it. Always .txt file
                    using (StreamWriter writer = File.CreateText($"{fileDialog.FileName}"))
                    {
                        foreach (ListViewItem result in this.outputListBox.Items)
                        {
                            writer.WriteLine($"{result.SubItems[0].Text} , {result.SubItems[1].Text} , {result.SubItems[2].Text}");
                        }
                    };
                }
                catch
                {
                    ShowMessageBox("Le fichier choisi n'a pas pu être ouvert. Veuillez vérifier que celui-ci ne soit pas utilisé par un autre processus et réessayer.");
                }
            }
        }

        /// <summary>
        /// Open system file explorer, let user select source folder
        /// </summary>
        private void OpenFolderIconClick(object sender,  EventArgs e)
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
        private void SearchButtonClick(object sender, EventArgs e)
        {
            //Clear the actual list and add to filtered results if match found
            this.FilteredResults.Clear();

            //Get the filteredResults from controller
            this.FilteredResults = this.Ctrler.FilterResults(this.Results, this.filtersTextBox.Text);

            //Print the results
            this.PrintResultsContent();

            // Nothing as been found
            if (this.FilteredResults.Count == 0)
            {
                this.ShowMessageBox("Aucun résultat n'a été trouvé avec ces filtres.");
            }
        }

        /// <summary>
        /// Remove the applied filters
        /// </summary>
        private void CancelButtonClick(object sender, EventArgs e)
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
        private void FileRadioButtonChecked(object sender, System.EventArgs e)
        {
            //Change icons for better clarity of what user can or can't do
            if (this.filesRadio.Checked)
            {
                this.openFolderPictureBox.Enabled = true;
                this.openFolderPictureBox.Image = Resources.iconsRes.folder_blue;
            }
            else
            {
                this.openFolderPictureBox.Enabled = false;
                this.openFolderPictureBox.Image = Resources.iconsRes.folder_gray;
            }
        }

        /// <summary>
        /// Empty and reset settings of the output box
        /// </summary>
        private void ResetOutputList()
        {
            this.outputListBox.Clear();
            this.outputListBox.Columns.Add("Type", 75);
            this.outputListBox.Columns.Add("Nom", 250);
            this.outputListBox.Columns.Add("Source", 450);
            this.outputListBox.AllowColumnReorder = true;
            this.outputListBox.FullRowSelect = true;
            this.outputListBox.MultiSelect = false;
            this.outputListBox.SmallImageList = this.IconsList;
        }

        /// <summary>
        /// Get the images from resource file (used for showing icons with results)
        /// </summary>
        private void GetImagesFromResource()
        {
            this.IconsList = new ImageList();
            this.IconsList.ImageSize = new Size(25, 25);
            this.IconsList.Images.Add((Image)Resources.iconsRes.folder_gray);
            this.IconsList.Images.Add((Image)Resources.iconsRes.fileIcon);
            this.IconsList.Images.Add((Image)Resources.iconsRes.emblem_symbolic_link);
            this.IconsList.Images.Add((Image)Resources.iconsRes.pictureImage);
        }

        /// <summary>
        /// When user focus enter to filterbox, change enter key validation button
        /// </summary>
        private void FilterBoxTakeFocus(object sender, EventArgs e)
        {
            this.AcceptButton = this.searchButton;
        }

        /// <summary>
        /// When user LEAVE the filterbox change enter key validation button
        /// </summary>
        private void FilterBoxLeaveFocus(object sender, EventArgs e)
        {
            this.AcceptButton = this.executeButton;
        }

        /// <summary>
        /// Set content of the path from controller
        /// </summary>
        /// <param name="content">The content to print</param>
        public void SetContentToPathTextBox(string content)
        {
            this.pathTextBox.Text = content;
            
            // The content is a link
            if(content.Contains("http://") || content.Contains("https://"))
            {
                this.webRadio.Checked = true;
                this.filesRadio.Checked = false;
            }
            else
            {
                this.filesRadio.Checked = true;
                this.webRadio.Checked = false;
            }
        }

        /// <summary>
        /// Show bookmarks list when user click show bookmarks
        /// </summary>
        private void ShowBookmarksClick(object sender, EventArgs e)
        {
            this.Ctrler.ShowHideBookmarksView();
        }

        /// <summary>
        /// Show create bookmark when user click add bookmark
        /// </summary>
        private void CreateBookmarkClick(object sender, EventArgs e)
        {
            this.Ctrler.ShowHideCreateBookmarkView(this.pathTextBox.Text);
        }

        /// <summary>
        /// Check if update needed to bookmark panel
        /// </summary>
        private void UpdateBookmark(object sender, EventArgs e)
        {
            this.Ctrler.CheckBookmark();
        }

        /// <summary>
        /// Change star color and message when bookmarks changes
        /// </summary>
        /// <param name="exists">if bookmark exists equal true, if not false</param>
        public void UpdateBookmarkPanel(bool exists)
        {
            if(exists)
            {
                this.favoritePictureBox.Image = Resources.iconsRes.filledYellowStar;
                this.addFavLbl.Text = "Cette source est présente\ndans la liste des favoris.";
            }
            else
            {
                this.favoritePictureBox.Image = Resources.iconsRes.filledStarGray;
                this.addFavLbl.Text = "Cette source n'est pas présente\ndans la liste des favoris.";
            }
        }

        /// <summary>
        /// Return the current path
        /// </summary>
        /// <returns>The current path</returns>
        public string GetCurrentPath()
        {
            return this.pathTextBox.Text;
        }
       
        /// <summary>
        /// When user click the display help menu run the help view 
        /// </summary>
        private void OpenHelpMenuStrip(object sender, EventArgs e)
        {
            this.Ctrler.ShowHideHelpView();
        }

        /// <summary>
        /// Check if user press a specific key on the keyboard
        /// </summary>
        void UserKeyPressed(object sender, KeyEventArgs e)
        {
            // User press F1 --> open or close helpview
            if (e.KeyCode.ToString() == "F1")
            {
                this.Ctrler.ShowHideHelpView();
            }

            // User press CTRL-S --> execute the exportation
            else if(e.KeyCode == Keys.S && (e.Control))
            {
                this.ExportDataButtonClick(null, null);
            }

            // User press A --> open the addBookmark view
            else if(e.KeyCode == Keys.A && (e.Control))
            {
                this.CreateBookmarkClick(null, null);
            }

            // User press E --> close the bookmarklist view
            else if(e.KeyCode == Keys.E && (e.Control))
            {
                this.Ctrler.ShowHideBookmarksView();
            }

            // User press Escape --> close the application
            else if (e.KeyCode == Keys.Escape)
            {
                this.ExitButtonClick(null, null);
            }
        }

        /// <summary>
        /// Give focus to pathLabel when user click form
        /// </summary>
        private void ResetFocus(object sender, EventArgs e)
        {
            this.pathLabel.Focus();
        }

        /// <summary>
        /// Open HelpMenu if user press one of the Help icons
        /// </summary>
        private void HelpIconClick(object sender, EventArgs e)
        {
            this.Ctrler.ShowHideHelpView();
        }
    }
}
