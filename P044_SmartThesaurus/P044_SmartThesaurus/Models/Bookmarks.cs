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
        public List<Bookmark> BookmarksObjects { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Bookmarks()
        {
            BookmarksPath = $"{Environment.CurrentDirectory}\\bookmarks.json";
            this.BookmarksObjects = new List<Bookmark>();

            // Create the bookmarks file if not exists
            this.CreateBookmarksFile();

            // Read content of the JSON file
            this.ReadFromFile();
        }

        /// <summary>
        /// Write bookmark to JSON file
        /// </summary>
        /// <param name="bookmark">The bookmark</param>
        public bool AddBookmark(Bookmark bookmark)
        {
            // Check if the bookmark does alrealy exists
            foreach (Bookmark existing in this.BookmarksObjects)
            {
                if (existing.Name == bookmark.Name)
                {
                    return false;
                }
            }

            this.BookmarksObjects.Add(bookmark);

            // Create the file if deleted
            if (!this.FileExists())
            {
                this.CreateBookmarksFile();
            }

            // Append new bookmark to bookmarks file
            File.WriteAllText(BookmarksPath, JsonConvert.SerializeObject(BookmarksObjects, Formatting.Indented));

            return true;
        }

        /// <summary>
        /// Remove a bookmark from the list of bookmarks and write new content to file
        /// </summary>
        /// <param name="bookmark">The bookmark name to remove</param>
        public void RemoveBookmark(string bookmarkName)
        {
            // Find the bookmark that we need to delete
            foreach(Bookmark existing in this.BookmarksObjects.ToArray())
            {
                // The bookmark as been found
                if(existing.Name == bookmarkName)
                {
                    this.BookmarksObjects.Remove(existing);
                    break;
                }
            }

            // Create the file if deleted
            if (!this.FileExists())
            {
                this.CreateBookmarksFile();
            }

            // Append new bookmark to bookmarks file
            File.WriteAllText(BookmarksPath, JsonConvert.SerializeObject(BookmarksObjects, Formatting.Indented));
        }

        /// <summary>
        /// Read json file and set properties for ldap class
        /// </summary>
        private void ReadFromFile()
        {
            if (this.FileExists())
            {
                // Read content of the file
                string jsonFileContent = File.ReadAllText(BookmarksPath);
                
                // If file contains elements, convert them to Bookmark objects
                if(jsonFileContent != "")
                {
                    this.BookmarksObjects = JsonConvert.DeserializeObject<List<Bookmark>>(jsonFileContent);
                }
            }
            else
            {
                this.CreateBookmarksFile();
                this.BookmarksObjects = new List<Bookmark>();
            }
        }

        /// <summary>
        /// Create file and fill it with formatted text if file does not exists
        /// </summary>
        private void CreateBookmarksFile()
        {
            // If the file does not exists alrealy
            if(!this.FileExists())
            {
                // Create the file and close the stream
                File.Create(BookmarksPath).Close();
            }
        }

        /// <summary>
        /// Check if the file alrealy exists
        /// </summary>
        /// <returns>true if exists, false if not</returns>
        private bool FileExists()
        {
            if(File.Exists(BookmarksPath))
            {
                return true;
            }
            return false;
        }
    }
}
