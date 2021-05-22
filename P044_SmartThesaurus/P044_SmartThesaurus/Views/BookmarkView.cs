/// ETML
/// Autor : Sébastien Duruz
/// Date : 22.05.2021
/// Description : This view let user view and manage his bookmarks

using P044_patcarqueijo_sebduruz.Controllers;
using P044_SmartThesaurus.AppBusiness;
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
            this.Ctrler.DeleteBookmark(this.bookmarksListView.SelectedItems[0].SubItems[0].Text);
            this.bookmarksListView.Items.Remove(this.bookmarksListView.SelectedItems[0]);
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
    }
}
