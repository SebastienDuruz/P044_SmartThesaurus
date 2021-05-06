/// ETML
/// Autor : Sébastien Duruz
/// Date : 12.03.2021
/// Description : The main controller of the application

using sebduruz_Index_FormTestProject.AppBusiness;
using sebduruz_Index_FormTestProject.Models.ObjectsIndex;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sebduruz_Index_FormTestProject.Controllers
{
    /// <summary>
    /// Class Controller
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Class Atributs
        /// </summary>
        private readonly MainView _mainView = new MainView();

        /// <summary>
        /// Class Properties
        /// </summary>
        private WebScraper WebScraper { get; set; }
        private FileIndexation FileIndexer { get; set; }

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

        /// <summary>
        /// Get all the files from indexed folder
        /// </summary>
        /// <param name="path">The path where to start indexation</param>
        /// <returns>List of files indexed</returns>
        public List<IObjectsIndex> GetFilesFromIndexation(string path)
        {
            //Get the instance and start indexing
            this.FileIndexer = FileIndexation.GetInstance(path);
            this.FileIndexer.ExecIndexation();

            //Return the results
            return this.FileIndexer.IndexationContent;
        }

        /// <summary>
        /// Get all links from webpage
        /// </summary>
        /// <param name="webPage">The webpage to search for links</param>
        /// <returns>List of links got from webScraper</returns>
        public List<IObjectsIndex> GetLinksFromWebScraper(string webPagePath)
        {
            //Get the instance and Get links from page
            this.WebScraper = WebScraper.GetInstance();
            string webPageContent = this.WebScraper.GetHtmlContent(webPagePath);
           
            if(webPageContent != null)
            {
                this.WebScraper.FindLinks(webPageContent);
            }

            //Return the results
            return this.WebScraper.Links;
        }

        /// <summary>
        /// Split the filters given by user
        /// </summary>
        /// <param name="filter">The full string containing filters</param>
        /// <returns>String array containing splited filters</returns>
        public string[] SplitFilters(string filter)
        {
            //Remove spaces
            filter = filter.Replace(" ", "");

            //Return the splited filters
            return filter.Split(';');
        }
    }
}
