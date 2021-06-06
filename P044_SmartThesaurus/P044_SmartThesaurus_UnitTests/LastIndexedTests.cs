/// ETML
/// Autor : Sébatien Duruz
/// Date 06.06.2021
/// Description : Unit tests for LastIndexed Class.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using P044_SmartThesaurus.Models;
using System;
using System.IO;

namespace P044_SmartThesaurus_UnitTests
{
    /// <summary>
    /// Class LastIndexedTests
    /// </summary>
    [TestClass]
    public class LastIndexedTests
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        private LastIndexed LastIndexedTester { get; set; }

        /// <summary>
        /// Test if the value given is correctly set to the text file
        /// </summary>
        [TestMethod]
        public void SetLastIndexedTest()
        {
            // Arrange
            string lastIndexedValue = "C:\\Test";
            string path = $"{Environment.CurrentDirectory}/lastIndexed.txt";
            string expected;

            // Act
            this.LastIndexedTester = new LastIndexed();
            this.LastIndexedTester.SetLastindexed(lastIndexedValue);
            expected = File.ReadAllText(path);

            // Assert
            Assert.AreEqual(expected.Trim(), lastIndexedValue);
        }

        /// <summary>
        /// Test if the value returns is the correct one from the text file
        /// </summary>
        [TestMethod]
        public void GetLastIndexedTest()
        {
            // Arrange
            string expected = "C:\\Test";
            string result;

            // Act
            this.LastIndexedTester = new LastIndexed();
            result = this.LastIndexedTester.GetLastIndexed();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
