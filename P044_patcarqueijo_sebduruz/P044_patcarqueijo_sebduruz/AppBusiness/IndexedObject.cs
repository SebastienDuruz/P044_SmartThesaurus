/// ETML
/// Autor : Sébastien Duruz
/// Date : 08.05.2021
/// Description : An object resulted from the indexation.

namespace P044_patcarqueijo_sebduruz.Resources.ObjectsIndex
{
    public class IndexedObject
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
        /// <param name="path">The path of the element</param>
        /// <param name="identifier">A file name / link specific to this element</param>
        /// <param name="type">The type of the element (file, folder, link)</param>
        public IndexedObject(string path, string identifier, string type)
        {
            this.Path = path;
            this.Name = identifier;
            this.Type = type;
        }
    }
}
