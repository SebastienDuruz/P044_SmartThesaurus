/// ETML
/// Autor : Sébastien Duruz
/// Date : 21.05.2021
/// Description : A structure stored as a JSON file using to store bookmarks set by the user.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace P044_SmartThesaurus.AppBusiness
{
    /// <summary>
    /// Class Bookmarks
    /// </summary>
    public class Bookmarks
    {
        /// <summary>
        /// Class properties
        /// </summary>
        private static string BookmarksPath { get; set; }
        public List<string[]> BookmarksObjects { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Bookmarks()
        {
            BookmarksPath = $"{Environment.CurrentDirectory}\\bookmarks.json";
            BookmarksObjects = new List<string[]>();
            CreateBookmarksFile();
        }

        /// <summary>
        /// Read json file and set properties for ldap class
        /// </summary>
        private string[] Read()
        {
            if (this.CheckFile())
            {
                // try to read options
                try
                {
                    dynamic results = JsonConvert.DeserializeObject<object>(File.ReadAllText(BookmarksPath));
                    return results;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Create file and fill it with formatted text if file does not exists
        /// </summary>
        public void CreateBookmarksFile()
        {
            // If the file does not exists alrealy
            if(!this.CheckFile())
            {
                dynamic lastUsed = new System.Dynamic.ExpandoObject();

                //Create object
                lastUsed.LastUsed = "ADSadads";

                // Create and populate the file
                File.Create(BookmarksPath).Close();
                File.WriteAllText(BookmarksPath, JsonConvert.SerializeObject(lastUsed, Formatting.Indented));
            }
        }

        /// <summary>
        /// Check if the file alrealy exists
        /// </summary>
        /// <returns>true if exists, false if not</returns>
        private bool CheckFile()
        {
            if(File.Exists(BookmarksPath))
            {
                return true;
            }
            return false;
        }
    }
}
