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

            Review testObj = new Review(expectedRating, expectedName, expectedTimeCreation);

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

            Review testObj = new Review(expectedRating, expectedName, expectedTimeCreation, expectedDesc);

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
        public void GetSerializedDataTestMethod()
        {
            RestaurantsInfo restaurantsList = new RestaurantsInfo();
            Dummy d = new RestaurantReviewsLibrary.Models.Dummy();
            int expected = d.GetRestaruantData().Count;

            restaurantsList.GetSerializedData();
            int actual = restaurantsList.List.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetTopAverageRatingsTestMethod()
        {
            RestaurantsInfo restaurantsList = new RestaurantsInfo();
            


            Assert.AreEqual(false, true);
        }
    }
}
