/// ETML
/// Autor : Sébastien Duruz
/// Date : 22.03.2021
/// Description : A basic project to test Web scraping.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using ScrapySharp;

namespace WikipediaScraperGame
{
    /// <summary>
    /// Class Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Class Atributs
        /// </summary>
        private static ScrapingBrowser _browser = new ScrapingBrowser();

        /// <summary>
        /// Method Main
        /// </summary>
        static void Main()
        {
            GetMainPageLinks("https://fr.wikipedia.org/wiki/Craigslist");

            Console.ReadLine();
        }

        static List<string> GetMainPageLinks(string url)
        {
            List<string> homePageLinks = new List<string>();
            HtmlNode html = GetHtml(url);
            IEnumerable<HtmlNode> links = html.CssSelect("a");

            foreach(var link in links)
            {
                if (link.Attributes["OuterHtml"].Value.Contains("href"))
                {
                    Console.WriteLine(link.Attributes["href"].Value);
                    homePageLinks.Add(link.Attributes["href"].Value);
                }
            }

            return homePageLinks;
        }

        /// <summary>
        /// Get a html page from browser
        /// </summary>
        /// <param name="url">The url to load</param>
        /// <returns>A html page got by the browser</returns>
        static HtmlNode GetHtml(string url)
        {
            WebPage webpage = _browser.NavigateToPage(new Uri(url));
            return webpage.Html;
        }
    }
}
