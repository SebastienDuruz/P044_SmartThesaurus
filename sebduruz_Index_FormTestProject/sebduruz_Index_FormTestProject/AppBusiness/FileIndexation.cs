/// ETML
/// Autor : Sébastien Duruz
/// Date : 02.05.2021
/// Description : Manipulation of indexation from Microsoft libraries. Use of Singleton principle

using sebduruz_Index_FormTestProject.Models;
using sebduruz_Index_FormTestProject.Models.ObjectsIndex;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace sebduruz_Index_FormTestProject.AppBusiness
{
    /// <summary>
    /// Class FileIndexation
    /// </summary>
    public class FileIndexation
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public string SourcePath { get; set; }
        public List<IObjectsIndex> IndexationContent { get; set; }
        private static FileIndexation Instance { get; set; }

        /// <summary>
        /// Custom Constructor
        /// </summary>
        /// <param name="sourcePath">The source path of starting folder</param>
        private FileIndexation(string sourcePath)
        {
            this.SourcePath = sourcePath;
            this.IndexationContent = new List<IObjectsIndex>();
        }

        /// <summary>
        /// Get the instance of the object
        /// </summary>
        /// <param name="sourcePath">The sourcePath from where indexation should start</param>
        /// <returns>The instance</returns>
        public static FileIndexation GetInstance(string sourcePath)
        {
            if(Instance == null)
            {
                Instance = new FileIndexation(sourcePath);
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
                Console.WriteLine("{0} is not a valid file or directory.", this.SourcePath);
            }
        }

        /// <summary>
        /// Process a directory from path
        /// </summary>
        /// <param name="targetDirectory">The Targeted directory path</param>
        public void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                this.IndexationContent.Add(new IndexedFile(targetDirectory, ProcessFile(fileName)));
            }

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                string[] splited = subdirectory.Split('\\');
                this.IndexationContent.Add(new IndexedFolder(targetDirectory, splited[splited.Count()-1]));
                ProcessDirectory(subdirectory);
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
