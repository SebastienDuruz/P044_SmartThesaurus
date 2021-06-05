/// ETML
/// Autor : Sébastien Duruz
/// Date : 05.06.2021
/// Description : Unit tests for Bookmark Class.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using P044_SmartThesaurus.AppBusiness;

namespace P044_SmartThesaurus_UnitTests
{
    /// <summary>
    /// Class BookmarkTests
    /// </summary>
    [TestClass]
    public class BookmarkTests
    {
        /// <summary>
        /// Check if Constructor set the correct value to property
        /// </summary>
        [TestMethod]
        public void BookmarkConstructorTest1()
        {
            // Arrange
            Bookmark bookmark;
            string expected = "this is my description";

            // Act
            bookmark = new Bookmark("C:\\", "My documents", "this is my description");

            // Assert
            Assert.AreEqual(expected, bookmark.Description);
        }

        /// <summary>
        /// Check if Constructor set the correct default value if not precised at creation of the object
        /// </summary>
        [TestMethod]
        public void BookmarkConstructorTest2()
        {
            // Arrange
            Bookmark bookmark;
            string expected = "";

            // Act
            bookmark = new Bookmark("C:\\", "My documents");

            // Assert
            Assert.AreEqual(expected, bookmark.Description);
        }
    }
}
