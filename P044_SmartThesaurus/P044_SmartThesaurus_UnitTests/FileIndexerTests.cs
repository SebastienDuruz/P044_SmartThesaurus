/// ETML
/// Autor : Sébastien Duruz
/// Date : 05.06.2021
/// Description : Unit tests for FileIndexer Class.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using P044_SmartThesaurus.AppBusiness;

namespace P044_SmartThesaurus_UnitTests
{
    /// <summary>
    /// Class FileIndexerTests
    /// </summary>
    [TestClass]
    public class FileIndexerTests
    {
        /// <summary>
        /// Check if GetInstance return a unique instance (check singleton principle)
        /// </summary>
        [TestMethod]
        public void GetInstanceTest()
        {
            // Arrange
            FileIndexer firstIndexer;
            FileIndexer secondIndexer;
            string sourcePath = "./";

            // Act
            firstIndexer = FileIndexer.GetInstance(sourcePath);
            secondIndexer = FileIndexer.GetInstance(sourcePath);

            // Assert
            Assert.AreSame(firstIndexer, secondIndexer);
        }

        /// <summary>
        /// Test if the method split the string correctly
        /// </summary>
        [TestMethod]
        public void ProcessFileTest()
        {
            // Arrange
            FileIndexer indexer;
            string basestring = @"C:\Program Files\Core Temp";
            string expected = "Core Temp";

            // Act
            indexer = FileIndexer.GetInstance("C:/Users");
            var privateIndexer = new PrivateObject(indexer);
            var result = privateIndexer.Invoke("ProcessFile", basestring);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
