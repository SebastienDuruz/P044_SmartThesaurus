/// ETML
/// Autor : Sébastien Duruz
/// Date : 24.04.2021
/// Description : A basic project to test Web scraping.
///               Inspired by https://www.dotnetperls.com/scraping-html for the creation of WebsiteIndexer Class.

using System;

namespace sebduruz_WebScraper
{
    /// <summary>
    /// Class Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        static void Main()
        {
            //Create the webScraper
            WebScraper webScraper = new WebScraper();

            //Find all links on specific page
            webScraper.FindLinks(webScraper.GetHtmlContent("https://fr.wikipedia.org/wiki/Alcest"));

            //Print the results
            foreach(string link in webScraper.Links)
            {
                Console.WriteLine(link);
            }

            Console.ReadLine();
        }
    }
}
