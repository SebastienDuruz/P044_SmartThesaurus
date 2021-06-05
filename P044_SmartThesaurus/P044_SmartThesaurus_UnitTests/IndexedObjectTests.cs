/// ETML
/// Autor : Sébastien Duruz
/// Date : 05.06.2021
/// Description : Unit tests for IndexedObject Class.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using P044_SmartThesaurus.AppBusiness;

namespace P044_SmartThesaurus_UnitTests
{
    /// <summary>
    /// Class IndexedObjectTests
    /// </summary>
    [TestClass]
    public class IndexedObjectTests
    {
        /// <summary>
        /// Check if Constructor set the correct value to property
        /// </summary>
        [TestMethod]
        public void IndexedObjectConstructorTest()
        {
            // Arrange
            IndexedObject indexedObject;
            string expected = "file.txt";

            // Act
            indexedObject = new IndexedObject("C:\\", "file.txt", "Fichier" );

            // Assert
            Assert.AreEqual(expected, indexedObject.Name);
        }
    }
}
