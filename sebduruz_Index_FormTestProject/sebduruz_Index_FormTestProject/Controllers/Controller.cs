/// ETML
/// Autor : Sébastien Duruz
/// Date : 12.03.2021
/// Description : The main controller of the application

using System.Windows.Forms;

namespace sebduruz_Index_FormTestProject.Controllers
{

    /// <summary>
    /// Class Controller
    /// </summary>
    public class Controller
    {
        private MainView _mainView = new MainView();

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Controller()
        {
            this._mainView.Ctrler = this;
        }

        /// <summary>
        /// Run the main view
        /// </summary>
        public void RunMainView()
        {
            Application.Run(this._mainView);
        }
    }

    
}
