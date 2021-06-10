/// ETML
/// Autor : Sébastien Duruz
/// Date : 22.05.2021
/// Description : This view let user view and manage his bookmarks

using P044_SmartThesaurus.AppBusiness;
using P044_SmartThesaurus.Controllers;
using System;
using System.Windows.Forms;

namespace P044_SmartThesaurus.Views
{
    /// <summary>
    /// Class BookmarkView
    /// </summary>
    public partial class BookmarkView : Form
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public MainController Ctrler { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BookmarkView()
        {
            InitializeComponent();

            // Add event to read user keys
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(UserKeyPressed);
        }

        /// <summary>
        /// Hide the form if close button clicked
        /// </summary>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.Ctrler.ShowHideBookmarksView();
        }

        /// <summary>
        /// Print the existing bookmarks to file
        /// </summary>
        public void PrintBookmarks()
        {
            // Clear the existing items
            this.bookmarksListView.Items.Clear();

            // Bookmarks are not empty
            if(this.Ctrler.GetBookmarks() != null)
            {
                // Print each bookmark
                foreach (Bookmark bookmark in this.Ctrler.GetBookmarks())
                {
                    this.bookmarksListView.Items.Add(new ListViewItem(new string[] { bookmark.Name, bookmark.Path, bookmark.Description }));
                }
            }
        }

        /// <summary>
        /// Delete the selected bookmark if delete button click
        /// </summary>
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            // Ask user for confirmation of the delete action
            DialogResult confirmResult = MessageBox.Show($"Etes vous sur de vouloir supprimer le favoris \"{this.bookmarksListView.SelectedItems[0].SubItems[0].Text}\" ?", "Valider la suppression", MessageBoxButtons.YesNo);

            // User confirms the delete action, remove the bookmark
            if (confirmResult == DialogResult.Yes)
            {
                this.Ctrler.DeleteBookmark(this.bookmarksListView.SelectedItems[0].SubItems[0].Text);
                this.bookmarksListView.Items.Remove(this.bookmarksListView.SelectedItems[0]);
                this.Ctrler.CheckBookmark();
            }
        }

        /// <summary>
        /// Change state of the buttons if item is selected or not
        /// </summary>
        private void SelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(this.bookmarksListView.SelectedItems.Count > 0)
            {
                this.deleteButton.Enabled = true;
                this.modifyButton.Enabled = true;
            }
            else
            {
                this.deleteButton.Enabled = false;
                this.modifyButton.Enabled = false;
            }
        }

        /// <summary>
        /// Open modify bookmark view when user select a bookmark
        /// </summary>
        private void ModifyButtonClick(object sender, EventArgs e)
        {
            this.Ctrler.ShowHideModifyBookmarkView(this.bookmarksListView.SelectedItems[0].SubItems[0].Text, this.bookmarksListView.SelectedItems[0].SubItems[1].Text, this.bookmarksListView.SelectedItems[0].SubItems[2].Text);
            this.modifyButton.Enabled = false;
            this.deleteButton.Enabled = false;
        }

        /// <summary>
        /// Load the bookmark to main view if user double click selection
        /// </summary>
        private void DoubleClickSelectedItem(object sender, EventArgs e)
        {
            this.Ctrler.LoadSelection(this.bookmarksListView.SelectedItems[0].SubItems[1].Text);
            this.Ctrler.ShowHideBookmarksView();
        }

        /// <summary>
        /// Check if user press a specific key on the keyboard
        /// </summary>
        void UserKeyPressed(object sender, KeyEventArgs e)
        {
            // User press E --> close the bookmarklist view
            if (e.KeyCode == Keys.E)
            {
                this.Ctrler.ShowHideBookmarksView();
            }
        }

        /// <summary>
        /// Desactivate the modify + delete buttons when bookmarks view is hide
        /// </summary>
        private void BookmarksViewVisibleChanged(object sender, EventArgs e)
        {
            // the form is hide disable the two buttons
            if(this.Visible == false)
            {
                this.modifyButton.Enabled = false;
                this.deleteButton.Enabled = false;
            }
        }
    }
}
