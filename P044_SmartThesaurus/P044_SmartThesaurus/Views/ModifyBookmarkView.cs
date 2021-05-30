/// ETML
/// Autor : Sébastien Duruz
/// Date : 23.05.2020
/// Description : This view let user modify an existing bookmark

using P044_SmartThesaurus.Controllers;
using System;
using System.Windows.Forms;

namespace P044_SmartThesaurus.Views
{
    /// <summary>
    /// Class ModifyBookmarkView
    /// </summary>
    public partial class ModifyBookmarkView : Form
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public MainController Ctrler { get; set; }
        private string OldBookmarkName { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ModifyBookmarkView()
        {
            InitializeComponent();
            this.OldBookmarkName = "";
        }

        /// <summary>
        /// Update the content of the form
        /// </summary>
        /// <param name="name">The name of the selected bookmark</param>
        /// <param name="path">The path of the selected bookmark</param>
        /// <param name="description">The description of the selected bookmark</param>
        public void UpdateContent(string name, string path, string description)
        {
            this.nameTextBox.Text = name;
            this.sourceTextBox.Text = path;
            this.descriptionTextBox.Text = description;

            this.OldBookmarkName = name;
        }

        /// <summary>
        /// Hide the modify form if user press cancel button
        /// </summary>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Ctrler.ShowHideModifyBookmarkView();
        }

        /// <summary>
        /// Update the selected bookmark if user press validate button
        /// </summary>
        private void AcceptButtonClick(object sender, EventArgs e)
        {
            if (this.nameTextBox.Text.Trim(' ') != "")
            {
                this.Ctrler.ModifyBookmark(this.nameTextBox.Text, this.sourceTextBox.Text, this.descriptionTextBox.Text, this.OldBookmarkName);
            }
        }
    }
}
