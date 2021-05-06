/// ETML
/// Autor : Sébastien Duruz
/// Date : 06.05.2021
/// Description : A folder object obtained from database

namespace sebduruz_Index_FormTestProject.Models.ObjectsIndex
{
    /// <summary>
    /// Class Folder
    /// </summary>
    public class IndexedFolder : IObjectsIndex
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
        /// <param name="path">The path of the folder</param>
        /// <param name="name">The folderName</param>
        public IndexedFolder(string path, string name)
        {
            this.Path = path;
            this.Name = name;
            this.Type = "Dossier";
        }
    }
}
