/// ETML
/// Autor : Sébastien Duruz
/// Date : 24.04.2021
/// Description : A basic project to test Web scraping.
///               Inspired by https://www.dotnetperls.com/scraping-html for the creation of WebsiteIndexer Class.

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace sebduruz_Index_FormTestProject.AppBusiness
{
    /// <summary>
    /// Class WebScraper
    /// </summary>
    public class WebScraper
    {
        /// <summary>
        /// Class Atributs
        /// </summary>
        private WebClient _client;

        /// <summary>
        /// Class Properties
        /// </summary>
        public List<string> Links { get; set; }
        private static WebScraper Instance { get; set; }

        /// <summary>
        /// Default Constuctor
        /// </summary>
        private WebScraper()
        {
            this._client = new WebClient();
            this._client.Headers.Add("User-Agent", "C# console program");
            this.Links = new List<string>();
        }

        /// <summary>
        /// Get the instance of the object
        /// </summary>
        /// <returns>The instance</returns>
        public static WebScraper GetInstance()
        {
            if (Instance == null)
            {
                Instance = new WebScraper();
            }

            return Instance;
        }

        /// <summary>
        /// Get the content of web page (HTML)
        /// </summary>
        /// <param name="url">The url of the webpage</param>
        /// <returns>A string containing the page data</returns>
        public string GetHtmlContent(string url)
        {
            //Try to get content from given URL
            try
            {
                return this._client.DownloadString(url);
            }
            //Return null if error
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Find all links contains into the page and set it into Links list
        /// </summary>
        /// <param name="file">The html file where to find</param>
        public void FindLinks(string file)
        {
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
                    //Keep only full links (start with http)
                    if (m2.Groups[1].Value.StartsWith("http"))
                    {
                        this.Links.Add(m2.Groups[1].Value);
                    }
                }
            }
        }
    }
}
