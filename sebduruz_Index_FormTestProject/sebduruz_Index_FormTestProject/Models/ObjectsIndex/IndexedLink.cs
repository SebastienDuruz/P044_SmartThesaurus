/// ETML
/// Autor : Sébastien Duruz
/// Date : 06.05.2021
/// Description : A Link object obtained from database


namespace sebduruz_Index_FormTestProject.Models.ObjectsIndex
{
    /// <summary>
    /// Class Folder
    /// </summary>
    public class IndexedLink : IObjectsIndex
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
        /// <param name="path">The path of the link (adress)</param>
        /// <param name="link">The link content</param>
        public IndexedLink(string path, string link)
        {
            this.Path = path;
            this.Name = link;
            this.Type = "Lien";
        }
    }
}
