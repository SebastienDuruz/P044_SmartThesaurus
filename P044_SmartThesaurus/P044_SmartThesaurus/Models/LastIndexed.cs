/// ETML
/// Autor : Sébastien Duruz
/// Date : 09.05.2021
/// Description : Basic model to get datas from differents sources.

using System;
using System.IO;

namespace P044_SmartThesaurus.Models
{
    /// <summary>
    /// Class Model
    /// </summary>
    public class LastIndexed
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        private string FilePath { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public LastIndexed()
        {
            this.FilePath = $"{Environment.CurrentDirectory}/lastIndexed.txt";
        }

        /// <summary>
        /// Get the lastIndexed
        /// </summary>
        /// <returns>A string with content of the last indexation path</returns>
        public string GetLastIndexed()
        {
            if (CheckFile())
            {
                return File.ReadAllText(this.FilePath).Trim('\n', '\r');
            }
            else
            {
                File.Create(this.FilePath);
                return "";
            }
        }

        /// <summary>
        /// Add the lastIndexed to file
        /// </summary>
        /// <param name="lastIndexed">The lastindexed folder source</param>
        public void SetLastindexed(string lastIndexed)
        {
            try
            {
                // Write the lastIndexed to file
                using (StreamWriter writer = new StreamWriter(this.FilePath))
                {
                    writer.WriteLine(lastIndexed);
                }
            }
            catch(Exception ex)
            {
                // Write the exception message to log.txt
                using (StreamWriter writer = new StreamWriter($"{Environment.CurrentDirectory}/log.txt"))
                {
                    writer.WriteLine($"Exception throwed from lastIndexed at [{DateTime.Now}] {ex.Message}\n{ex.StackTrace}");
                }
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
