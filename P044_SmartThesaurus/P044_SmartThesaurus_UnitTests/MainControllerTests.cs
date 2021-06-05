/// ETML
/// Autor : Sébastien Duruz
/// Date : 05.06.2021
/// Description : Unit tests for MainController Class.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using P044_SmartThesaurus.AppBusiness;
using P044_SmartThesaurus.Controllers;
using System.Collections.Generic;

namespace P044_SmartThesaurus_UnitTests
{
    /// <summary>
    /// Class TestClass
    /// </summary>
    [TestClass]
    public class MainControllerTests
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public MainController Controller { get; set; }

        /// <summary>
        /// Test if the filters are correctly applied
        /// </summary>
        [TestMethod]
        public void FilterResultsTest()
        {
            // Arrange
            List<IndexedObject> objects;
            List<IndexedObject> result;
            string filter = "www : .ch";
            int expected = 2;

            // Act
            this.Controller = new MainController();
            objects = new List<IndexedObject>();
            objects.Add(new IndexedObject("C:\\Tests", "www.etml.ch", "Lien"));
            objects.Add(new IndexedObject("C:\\Tests", "www.eduvaud.ch", "Lien"));
            objects.Add(new IndexedObject("C:\\Tests", "www.wikipedia.com", "Lien"));

            result = this.Controller.FilterResults(objects, filter);

            // Assert
            Assert.AreEqual(expected, result.Count);
        }

        /// <summary>
        /// Test if the filters are correctly splited
        /// </summary>
        [TestMethod]
        public void SplitFiltersTest()
        {
            // Arrange
            string filter = "bye    | \n hello";
            string[] expected = new string[]{ "bye", "hello"};

            // Act
            this.Controller = new MainController();
            string[] results = this.Controller.SplitFilters(filter);

            // Assert
            Assert.AreEqual(expected[0], results[0]);
        }
    }
}
