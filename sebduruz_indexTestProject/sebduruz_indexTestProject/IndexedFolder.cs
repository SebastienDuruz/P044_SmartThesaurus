/// ETML
/// Autor : Sébastien Duruz
/// Date : 19.02.2021
/// Description : A basic test project, try to use indexation functions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebduruz_indexTestProject
{
    /// <summary>
    /// Class IndexedFolder
    /// </summary>
    public class IndexedFolder
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        private string FolderPath { get; set; }
        public List<IndexedFile> FolderFiles { get; set; }
        public List<IndexedFile> FolderSubFolders { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public IndexedFolder(string source)
        {
            this.FolderPath = source;

        }
    }
}
