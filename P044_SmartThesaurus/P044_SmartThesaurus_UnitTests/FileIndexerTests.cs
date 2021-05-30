using Microsoft.VisualStudio.TestTools.UnitTesting;
using P044_SmartThesaurus.AppBusiness;

namespace P044_SmartThesaurus_UnitTests
{
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
    }
}
