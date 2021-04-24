/// ETML
/// Autor : Sébastien Duruz
/// Date : 22.03.2021
/// Description : A basic project to test Web scraping. Inspired by https://www.dotnetperls.com/scraping-html for the creation of WebsiteIndexer Class.

using System;

namespace WikipediaScraperGame
{
    /// <summary>
    /// Class Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Method Main
        /// </summary>
        static void Main()
        {
            //Variables
            WebsiteIndex pageContent = new WebsiteIndex();

            //Get the content from url
            string html = pageContent.GetHtmlContent("https://fr.wikipedia.org/wiki/Wikip%C3%A9dia:Accueil_principal");

            //Find each urls
            pageContent.FindLinks(html);

            // Print each links contains into list
            foreach (string link in pageContent.Links)
            {
               Console.WriteLine($"{link}");
            }

            Console.ReadLine();
        }
    }
}
