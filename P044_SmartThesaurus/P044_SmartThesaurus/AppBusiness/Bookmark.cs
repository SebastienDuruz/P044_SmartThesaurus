/// ETML
/// Autor : Sébastien Duruz
/// Date : 22.05.2021
/// Description : A class representing Bookmark objects that will be converted to JSON

namespace P044_SmartThesaurus.AppBusiness
{
    /// <summary>
    /// Class Bookmark
    /// </summary>
    public class Bookmark
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public string Path { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Custom Constructor
        /// </summary>
        /// <param name="path">The path (or weblink)</param>
        /// <param name="name">The name</param>
        /// <param name="description">The description (can be empty)</param>
        public Bookmark(string path, string name, string description = "")
        {
            this.Path = path;
            this.Name = name;
            this.Description = description;
        }
    }
}
