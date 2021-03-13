/// ETML
/// Autor : Sébastien Duruz
/// Date : 12.03.2021
/// Description : Test how to index file with Microsoft libraries

using System;
using System.IO;
using System.Linq;

namespace sebduruz_indexTestProject.Indexation
{
    /// <summary>
    /// Class FileIndexation
    /// </summary>
    public class FileIndexation
    {
        public string _sourcePath;

        /// <summary>
        /// Custom Constructor
        /// </summary>
        /// <param name="sourcePath">The source path of starting folder</param>
        public FileIndexation(string sourcePath)
        {
            this._sourcePath = sourcePath;
        }

        /// <summary>
        /// Exec the indexation from the sourcePath
        /// </summary>
        public void ExecIndexation()
        {
            if (File.Exists(this._sourcePath))
            {
                // This path is a file
                ProcessFile(this._sourcePath);
            }
            else if (Directory.Exists(this._sourcePath))
            {
                // This path is a directory
                ProcessDirectory(this._sourcePath);
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", this._sourcePath);
            }
        }

        /// <summary>
        /// Process a directory from path
        /// </summary>
        /// <param name="targetDirectory">The Targeted directory path</param>
        public static void ProcessDirectory(string targetDirectory)
        {
            //Console.WriteLine(targetDirectory);
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        /// <summary>
        /// Process a file
        /// </summary>
        /// <param name="path">The path to process</param>
        public static void ProcessFile(string path)
        {
            string[] parts = path.Split('\\');
            path = parts[parts.Count() - 1];
            //Console.WriteLine("Processed file '{0}'.", path);
        }
    }
}
