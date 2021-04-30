/// ETML
/// Autor : Sébastien Duruz
/// Date : 12.03.2021
/// Description : The main view of the application

using sebduruz_Index_FormTestProject.Controllers;
using sebduruz_indexTestProject.Indexation;
using sebduruz_WebScraper;
using System.Windows.Forms;

namespace sebduruz_Index_FormTestProject
{
    public partial class MainView : Form
    {
        /// <summary>
        /// Class Atributs
        /// </summary>
        public Controller Ctrler { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Execute the indexation when exec button clicked
        /// </summary>
        private void ExecButton(object sender, System.EventArgs e)
        {
            WebScraper web = new WebScraper();
            if(this.filesRadio.Checked)
            {
                FileIndexation file = new FileIndexation(this.pathTextBox.Text);
                file.ExecIndexation();
                foreach (string x in file.Files)
                {
                    this.outputBox.Text += $"{x}\n";
                }
            }
            else
            {
                string webpage = web.GetHtmlContent(this.pathTextBox.Text);
                web.FindLinks(webpage);

                foreach(string link in web.Links)
                {
                    this.outputBox.Text += $"{link}\n";
                }
            }
        }
    }
}
