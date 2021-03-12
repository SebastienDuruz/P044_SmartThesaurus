using sebduruz_Index_FormTestProject.Controllers;
using System;
using System.Windows.Forms;

namespace sebduruz_Index_FormTestProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controller ctrler = new Controller();

            ctrler.RunMainView();
        }
    }
}
