/// ETML
/// Autor : Sébastien Duruz
/// Date : 22.05.2020
/// Description : This view let user Create a new bookmark

using P044_SmartThesaurus.Controllers;
using System;
using System.Windows.Forms;

namespace P044_SmartThesaurus.Views
{
    /// <summary>
    /// Class CreateBookmarkView
    /// </summary>
    public partial class CreateBookmarkView : Form
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public MainController Ctrler { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CreateBookmarkView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hide the form if user press cancel button
        /// </summary>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Ctrler.ShowHideCreateBookmarkView();
        }

        /// <summary>
        /// Update the path content
        /// </summary>
        /// <param name="path">the path (or link)</param>
        public void UpdatePathContent(string path)
        {
            this.sourceTextBox.Text = path;
        }

        /// <summary>
        /// Add the bookmark created by user
        /// </summary>
        private void ValidateButton(object sender, EventArgs e)
        {
            // The name text box can't be empty
            if(this.nameTextBox.Text.Trim(' ') != "")
            {
                this.Ctrler.AddBookmark(this.nameTextBox.Text, this.sourceTextBox.Text, this.descriptionTextBox.Text);
                this.Ctrler.CheckBookmark();
            }
        }

        /// <summary>
        /// Clear the text box
        /// </summary>
        public void ClearCreationForm()
        {
            this.nameTextBox.Text = "";
            this.descriptionTextBox.Text = "";
        }
    }
}
