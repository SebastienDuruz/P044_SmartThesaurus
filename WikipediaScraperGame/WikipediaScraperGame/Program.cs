/// ETML
/// Autor : Sébastien Duruz
/// Date : 22.03.2021
/// Description : A basic project to test Web scraping. Inspired by https://www.dotnetperls.com/scraping-html for the creation of WebsiteIndexer Class.

using System;
using System.Collections.Generic;

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
            List<string> links = new List<string>();

            //Get the content from url
            string html = pageContent.GetHtmlContent("https://fr.wikipedia.org/wiki/Wikip%C3%A9dia:Accueil_principal");

            //Find each urls
            links = pageContent.Find(html);

            // Print each links contains into list
            foreach (string link in links)
            {
                Console.WriteLine($"{link}");
            }

            Console.ReadLine();
        }
    }
}
