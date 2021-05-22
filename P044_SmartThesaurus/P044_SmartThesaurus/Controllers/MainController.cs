/// ETML
/// Autor : Sébastien Duruz
/// Date : 08.05.2021
/// Description : The main controller of the application

using P044_patcarqueijo_sebduruz.AppBusiness;
using P044_patcarqueijo_sebduruz.Models;
using P044_SmartThesaurus;
using P044_SmartThesaurus.AppBusiness;
using P044_SmartThesaurus.Resources.ObjectsIndex;
using P044_SmartThesaurus.Views;
using System.Collections.Generic;
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
        private readonly BookmarkView _bookmarksView = new BookmarkView();
        private readonly CreateBookmarkView _createBookmarkView = new CreateBookmarkView();
        private readonly LastIndexed _model = new LastIndexed();
        private readonly Bookmarks _bookmarks = new Bookmarks();


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
            this._bookmarksView.Ctrler = this;
            this._createBookmarkView.Ctrler = this;
        }

        /// <summary>
        /// Run the main view
        /// </summary>
        public void RunMainView()
        {
            this.GetLastIndexed();
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

        /// <summary>
        /// Get last indexed from model
        /// </summary>
        public void GetLastIndexed()
        {
            this._mainView.SetContentToPathTextBox(this._model.GetLastIndexed());
        }

        /// <summary>
        /// Set the last indexed to model
        /// </summary>
        /// <param name="lastIndex"></param>
        public void SetLastIndexed(string lastIndex)
        {
            this._model.SetLastindexed(lastIndex);
        }

        /// <summary>
        /// Show or hide the bookmarks view, update the path content if needed
        /// </summary>
        /// <param name="pathContent"></param>
        public void ShowHideCreateBookmarkView(string pathContent = "")
        {
            if (this._createBookmarkView.Visible)
            {
                this._createBookmarkView.Hide();
            }
            else
            {
                this._createBookmarkView.Show();
                this._createBookmarkView.UpdatePathContent(pathContent);
            }
        }

        /// <summary>
        /// Show or hide the bookmarks view
        /// </summary>
        public void ShowHideBookmarksView()
        {
            if(this._bookmarksView.Visible)
            {
                this._bookmarksView.Hide();
            }
            else
            {
                this._bookmarksView.Show();
                this._bookmarksView.PrintBookmarks();
            }
        }

        /// <summary>
        /// Get bookmarks from model
        /// </summary>
        /// <returns>A list of bookmarks</returns>
        public List<Bookmark> GetBookmarks()
        {
            if(this._bookmarks.BookmarksObjects.Count != 0)
            {
                return this._bookmarks.BookmarksObjects;
            }
            return null;
        }

        /// <summary>
        /// Delete the bookmark from file
        /// </summary>
        /// <param name="bookmarkName">The bookmark name to delete</param>
        public void DeleteBookmark(string bookmarkName)
        {
            this._bookmarks.RemoveBookmark(bookmarkName);
        }

        /// <summary>
        /// Create bookmark
        /// </summary>
        /// <param name="name">The name of the bookmark</param>
        /// <param name="path">The path or link of the bookmark</param>
        /// <param name="description">The description of the bookmark</param>
        public void AddBookmark(string name, string path, string description)
        {
            this._bookmarks.AddBookmark(new Bookmark(path, name, description));
        }
    }
}
