/// ETML
/// Autor : Sébastien Duruz
/// Date : 19.02.2021
/// Description : A basic test project, try to use indexation functions.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebduruz_indexTestProject
{
    /// <summary>
    /// Class Indexation
    /// </summary>
    public class Indexation
    {
        /// <summary>
        /// Class atributs
        /// </summary>
        private string _source;
        private string[] _allFiles;


        /// <summary>
        /// Custom Constructor
        /// </summary>
        /// <param name="source">The source (where indexation should be executed</param>
        public Indexation(string source)
        {
            this._source = source;
            this._allFiles = Directory.GetFiles(this._source, ".");
            //Directory.GetDirectories
            ExecIndexation();
        }

        /// <summary>
        /// Execute and print the indexation result onto console
        /// </summary>
        private void ExecIndexation()
        {
            foreach (string file in _allFiles)
            {
                FileInfo info = new FileInfo(file);
                Console.WriteLine(info);
            }
        }
    }
}
