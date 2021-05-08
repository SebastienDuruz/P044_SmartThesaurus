/// ETML
/// Autor : Sébastien Duruz
/// Date : 02.05.2021
/// Description : Manipulation of indexation from Microsoft libraries. Use of Singleton principle

using P044_patcarqueijo_sebduruz.Resources.ObjectsIndex;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P044_patcarqueijo_sebduruz.AppBusiness
{
    /// <summary>
    /// Class FileIndexer
    /// </summary>
    public class FileIndexer
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public List<IndexedObject> IndexationContent { get; set; }
        private string SourcePath { get; set; }
        private static FileIndexer Instance { get; set; }

        /// <summary>
        /// Custom Constructor
        /// </summary>
        /// <param name="sourcePath">The source path of starting folder</param>
        private FileIndexer(string sourcePath)
        {
            this.SourcePath = sourcePath;
            this.IndexationContent = new List<IndexedObject>();
        }

        /// <summary>
        /// Get the instance of the object
        /// </summary>
        /// <param name="sourcePath">The sourcePath from where indexation should start</param>
        /// <returns>The instance</returns>
        public static FileIndexer GetInstance(string sourcePath)
        {
            if (Instance == null)
            {
                Instance = new FileIndexer(sourcePath);
            }
            else
            {
                Instance.SourcePath = sourcePath;
            }

            return Instance;
        }

        /// <summary>
        /// Exec the indexation from the sourcePath
        /// </summary>
        public void ExecIndexation()
        {
            // Check if location / file exists
            if (File.Exists(this.SourcePath))
            {
                // This path is a file
                ProcessFile(this.SourcePath);
            }
            else if (Directory.Exists(this.SourcePath))
            {
                // This path is a directory
                ProcessDirectory(this.SourcePath);
            }
            else
            {
                //TODO : Throw exeption
                Console.WriteLine("{0} is not a valid file or directory.", this.SourcePath);
            }
        }

        /// <summary>
        /// Process a directory from path
        /// </summary>
        /// <param name="targetDirectory">The Targeted directory path</param>
        public void ProcessDirectory(string targetDirectory)
        {
            List<string> fileEntries = new List<string>();
            bool folderIsAccessible = false;

            // Process the list of files found in the directory.
            try
            {
                fileEntries = Directory.GetFiles(targetDirectory).ToList();
                folderIsAccessible = true;
            }
            catch
            {
                //TODO : Use the exeption to notify user of the failed folder access
            }

            if(folderIsAccessible)
            {
                foreach (string fileName in fileEntries)
                {
                    this.IndexationContent.Add(new IndexedObject(targetDirectory, ProcessFile(fileName), "Fichier"));
                }

                // Recurse into subdirectories of this directory.
                string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
                foreach (string subdirectory in subdirectoryEntries)
                {
                    string[] splited = subdirectory.Split('\\');
                    this.IndexationContent.Add(new IndexedObject(targetDirectory, splited[splited.Count() - 1], "Dossier"));
                    ProcessDirectory(subdirectory);
                }
            }
        }

        /// <summary>
        /// Process a file
        /// </summary>
        /// <param name="path">The path to process</param>
        public static string ProcessFile(string path)
        {
            string[] parts = path.Split('\\');
            return parts[parts.Count() - 1];
        }
    }
}
