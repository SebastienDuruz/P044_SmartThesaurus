/// ETML
/// Autor : Sébastien Duruz
/// Date : 12.03.2021
/// Description : The main view of the application

using sebduruz_Index_FormTestProject.Controllers;
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
    }
}
