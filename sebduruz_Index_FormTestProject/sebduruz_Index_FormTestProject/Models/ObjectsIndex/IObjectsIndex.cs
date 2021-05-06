/// ETML
/// Autor : Sébastien Duruz
/// Date : 06.05.2021
/// Description : Interface for types of objects stored in the DB. Used as a bridge from DB to Application.


namespace sebduruz_Index_FormTestProject.Models.ObjectsIndex
{
    public interface IObjectsIndex
    {
        /// <summary>
        /// Interface Properties
        /// </summary>
        string Path { get; set; }
        string Name { get; set; }
        string Type { get; set; }
    }
}
