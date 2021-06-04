/// Autor : Patricia Carqueijo Ribeiro
/// Date : 04.06.2021
/// Description : Help View class, help view with all the tips to help the user

using P044_SmartThesaurus.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace P044_SmartThesaurus
{
    public partial class HelpView : Form
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public MainController Ctrler { get; set; }
        private ImageList IconsList { get; set; }

        /// <summary>
        /// Default Constuctor
        /// </summary>
        public HelpView()
        {
            InitializeComponent();
            this.GetImagesFromResource();

            // Add event to read user keys
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(UserKeyPressed);
        }

        /// <summary>
        /// Get the images from resource file (used for showing icon)
        /// </summary>
        private void GetImagesFromResource()
        {
            this.IconsList = new ImageList();
            this.IconsList.ImageSize = new Size(30, 30);
        }

        /// <summary>
        /// Check if user press a specific key on the keyboard
        /// </summary>
        private void UserKeyPressed(object sender, KeyEventArgs e)
        {
            // User press F1 --> open or close helpview
            if (e.KeyCode.ToString() == "F1")
            {
                this.Ctrler.ShowHideHelpView();
            }
        }

        /// <summary>
        /// Hide the form if the close button as been pressed
        /// </summary>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }
    }
}
