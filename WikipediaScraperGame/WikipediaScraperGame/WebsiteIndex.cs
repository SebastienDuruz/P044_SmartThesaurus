/// ETML
/// Autor : Sébastien Duruz
/// Date : 22.03.2021
/// Description : A basic project to test Web scraping.
///               Inspired by https://www.dotnetperls.com/scraping-html for the creation of WebsiteIndexer Class.

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace WikipediaScraperGame
{
    /// <summary>
    /// Class WebsiteIndex
    /// </summary>
    public class WebsiteIndex
    {
        /// <summary>
        /// Class Atributs
        /// </summary>
        WebClient _client;

        /// <summary>
        /// Default Constuctor
        /// </summary>
        public WebsiteIndex()
        {
            this._client = new WebClient();
            this._client.Headers.Add("User-Agent", "C# console program");
        }

        /// <summary>
        /// Get the content of web page (HTML)
        /// </summary>
        /// <param name="url">The url of the webpage</param>
        /// <returns>A string containing the page data</returns>
        public string GetHtmlContent(string url)
        {
            string content = null;

            //Try to get content from given URL
            try
            {
                content = this._client.DownloadString(url);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return content;
        }

        /// <summary>
        /// Find all links contains into the page
        /// </summary>
        /// <param name="file">The file where to find</param>
        /// <returns>A list of items (the links)</returns>
        public List<string> Find(string file)
        {
            List<string> list = new List<string>();
            string link = "";

            // Find all matches in file.
            MatchCollection m1 = Regex.Matches(file, @"(<a.*?>.*?</a>)",
                RegexOptions.Singleline);

            // Loop over each match.
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;

                // Get href attribute.
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""", RegexOptions.Singleline);
                if (m2.Success)
                {
                    link = m2.Groups[1].Value;
                }

                // Remove inner tags from text.
                string t = Regex.Replace(value, @"\s*<.*?>\s*", "",
                    RegexOptions.Singleline);
                link += $"\n\t {t}";

                list.Add(link);
            }
            return list;
        }
    }
}
