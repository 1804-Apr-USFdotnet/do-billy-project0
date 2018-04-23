using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PalindromeCheck;

namespace PalindromesUnitTest
{
    [TestClass]
    public class PalindromesUnitTest1
    {
        [TestMethod]
        public void IsPlaindromeTestMethod1()
        {
            // Arrange
            string forward = "racecar";
            bool expected = true;

            // Act
            bool actual = Palindromes.IsPalindrome(forward);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPlaindromeTestMethod2()
        {
            // Arrange
            string forward = "race car";
            bool expected = true;

            // Act
            bool actual = Palindromes.IsPalindrome(forward);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPlaindromeTestMethod3()
        {
            // Arrange
            string forward = "Never Odd Or Even";
            bool expected = true;

            // Act
            bool actual = Palindromes.IsPalindrome(forward);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPlaindromeTestMethod4()
        {
            // Arrange
            string forward = "Never Odd, Or Even";
            bool expected = true;

            // Act
            bool actual = Palindromes.IsPalindrome(forward);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
