/// ETML
/// Autor : Sébastien Duruz
/// Date : 08.05.2021
/// Description : The main controller of the application

using P044_patcarqueijo_sebduruz.AppBusiness;
using P044_patcarqueijo_sebduruz.Models;
using P044_patcarqueijo_sebduruz.Resources.ObjectsIndex;
using System.Collections.Generic;
using System.Resources;
using System.Windows.Forms;

namespace P044_patcarqueijo_sebduruz.Controllers
{
    public class MainController
    {
        /// <summary>
        /// Class Consts
        /// </summary>
        const char FILTER_OR = '|';
        const char FILTER_AND = ':';

        /// <summary>
        /// Class Atributs
        /// </summary>
        private readonly MainView _mainView = new MainView();
        private readonly Model _model = new Model();

        /// <summary>
        /// Class Properties
        /// </summary>
        private WebScraper WebScraper { get; set; }
        private FileIndexer FileIndexer { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainController()
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
        public List<IndexedObject> GetFilesFromIndexation(string path)
        {
            //Get the instance and start indexing
            this.FileIndexer = FileIndexer.GetInstance(path);
            this.FileIndexer.ExecIndexation();

            //Return the results
            return this.FileIndexer.IndexationContent;
        }

        /// <summary>
        /// Get all links from webpage
        /// </summary>
        /// <param name="webPage">The webpage to search for links</param>
        /// <returns>List of links got from webScraper</returns>
        public List<IndexedObject> GetLinksFromWebScraper(string webPagePath)
        {
            //Get the instance and Get links from page
            this.WebScraper = WebScraper.GetInstance();
            string webPageContent = this.WebScraper.GetHtmlContent(webPagePath);

            if (webPageContent != null)
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
            //Remove spaces and return to line
            filter = filter.Replace(" ", "");
            filter = filter.Replace("\n", "");

            //Return the splited filters
            return filter.Split(FILTER_OR);
        }

        /// <summary>
        /// Apply filters given by user
        /// </summary>
        /// <param name="results">The full results content</param>
        /// <param name="filters">The filters given by user</param>
        /// <returns></returns>
        public List<IndexedObject> FilterResults(List<IndexedObject> results, string filters)
        {
            //Create empty list for storing filtered results
            List<IndexedObject> filteredResults = new List<IndexedObject>();

            //turn to false if don't match (foreach filter)
            bool match;

            //Get the splited filters
            string[] splitedFilters = SplitFilters(filters);

            //Check each filters
            foreach (string filter in splitedFilters)
            {
                //if filter is not empty space
                if (filter.Trim(' ') != "")
                {
                    //Split filters that should be combined
                    string[] splited = filter.Split(FILTER_AND);

                    // Check all objects in Results list
                    foreach (IndexedObject result in results)
                    {
                        match = true;

                        //Check all filters that need to be combined
                        foreach (string filterToCombine in splited)
                        {
                            //Is matching do nothing
                            if (result.Name.Contains(filterToCombine) && !filteredResults.Contains(result))
                            {

                            }
                            //Does not match
                            else
                            {
                                match = false;
                            }
                        }

                        if (match)
                        {
                            filteredResults.Add(result);
                        }
                    }
                }
            }

            //Return the results
            return filteredResults;
        }
    }
}
