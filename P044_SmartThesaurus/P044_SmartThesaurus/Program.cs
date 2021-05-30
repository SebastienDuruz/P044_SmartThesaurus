using P044_SmartThesaurus.Controllers;
using System;
using System.Windows.Forms;

namespace P044_SmartThesaurus
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

            // Instanciation of the main controler
            MainController ctrler = new MainController();

            // Run the program from MainView
            ctrler.RunMainView();
        }
    }
}
