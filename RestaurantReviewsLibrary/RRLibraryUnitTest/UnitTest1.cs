using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using RestaurantReviewsLibrary.Models;

namespace RRLibraryUnitTest
{
    [TestClass]
    public class RestaurantsUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(false, true);
        }
    }

    [TestClass]
    public class ReviewsUnitTest
    {
        [TestMethod]
        public void ReviewCreationTestMethod1()
        {
            DateTime expectedTimeCreation = DateTime.Now;
            int expectedRating = 3;
            string expectedName = "John Doe";
            string expectedDesc = "";

            review testObj = new review(expectedRating, expectedName, expectedTimeCreation);

            Assert.AreEqual(expectedRating, testObj.Rating);
            Assert.AreEqual(expectedName, testObj.ReviewerName);
            Assert.AreEqual(expectedTimeCreation, testObj.ReviewCreatedTime);
            Assert.AreEqual(expectedDesc, testObj.Description);

        }

        [TestMethod]
        public void ReviewCreationTestMethod2()
        {
            DateTime expectedTimeCreation = DateTime.Now;
            int expectedRating = 1;
            string expectedName = "Harrison Gerbil Ulysses";
            string expectedDesc = "I'm pretty sure a rat swam in my soup.";

            review testObj = new review(expectedRating, expectedName, expectedTimeCreation, expectedDesc);

            Assert.AreEqual(expectedRating, testObj.Rating);
            Assert.AreEqual(expectedName, testObj.ReviewerName);
            Assert.AreEqual(expectedTimeCreation, testObj.ReviewCreatedTime);
            Assert.AreEqual(expectedDesc, testObj.Description);

        }
    }

    [TestClass]
    public class RestaurantsListUnitTest
    {
        [TestMethod]
        public void GetTopAverageRatingsTestMethod()
        {
            RestaurantsList restaurantsList = new RestaurantsList();
            


            Assert.AreEqual(false, true);
        }
    }
}
