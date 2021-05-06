/// ETML
/// Autor : Sébastien Duruz
/// Date : 06.05.2021
/// Description : A file object obtained from database

namespace sebduruz_Index_FormTestProject.Models.ObjectsIndex
{
    /// <summary>
    /// Class Folder
    /// </summary>
    public class IndexedFile : IObjectsIndex
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public string Path { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// Custom Constructor
        /// </summary>
        /// <param name="path">The path of the file</param>
        /// <param name="fileName">The file name</param>
        public IndexedFile(string path, string fileName)
        {
            this.Path = path;
            this.Name = fileName;
            this.Type = "Fichier";
        }
    }
}
