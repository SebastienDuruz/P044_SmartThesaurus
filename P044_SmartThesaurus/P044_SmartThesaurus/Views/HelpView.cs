// TODO : Add Pat header

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
        /// Hide the form if the close button as been pressed
        /// </summary>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }
    }
}
