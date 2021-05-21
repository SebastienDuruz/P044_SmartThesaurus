/// ETML
/// Autor : Sébastien Duruz
/// Date : 09.05.2021
/// Description : Basic model to get datas from differents sources.

using P044_SmartThesaurus.AppBusiness;
using System;
using System.IO;

namespace P044_patcarqueijo_sebduruz.Models
{
    /// <summary>
    /// Class Model
    /// </summary>
    public class Model
    {
        private  string FilePath { get; set; }
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Model()
        {
            this.FilePath = $@"{Environment.CurrentDirectory}/lastIndexed.txt";
        }


        /// <summary>
        /// Get the lastIndexed
        /// </summary>
        /// <returns>A string with content of the last indexation path</returns>
        public string GetLastIndexed()
        {
            if (CheckFile())
            {
                string test = File.ReadAllText(this.FilePath);
                return test;
            }
            else
            {
                File.Create(this.FilePath);
                return "";
            }
        }

        public void SetLastindexed(string lastIndexed)
        {
            // Write the lastIndexed to file
            using (StreamWriter writer = new StreamWriter(this.FilePath))
            {
                writer.WriteLine(lastIndexed);
            }
        }

        /// <summary>
        /// Check if the file alrealy exists
        /// </summary>
        /// <returns>true if exists, false if not</returns>
        private bool CheckFile()
        {
            if (File.Exists(this.FilePath))
            {
                return true;
            }
            return false;
        }
    }
}
