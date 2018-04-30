using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviewsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary.Models.Tests
{
    [TestClass()]
    public class RestaurantsInfoUnitTests
    {
        [TestMethod()]
        public void RestaurantsInfoConstructorTest()
        {
            RestaurantsInfo infoObj = new RestaurantsInfo();
            int expected = 7;
            int expectedReviewCount = 4;

            var actual = infoObj.ListOfRestaurants.Count();
            int actualReviewCount = infoObj.ListOfRestaurants.ElementAt(4).ReviewCount;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedReviewCount, actualReviewCount);
        }


        [TestMethod()]
        public void GetTopRestaurantsTest()
        {
            // Dummy Data: Franklin BBQ, Pizza Place (Tallahassee), Checkers
            RestaurantsInfo infoObj = new RestaurantsInfo();
            string first = "Franklin BBQ";
            string second = "Pizza Place";
            string secondLocation = "Tallahassee";
            string third = "Checkers";

            var a = infoObj.GetTopRestaurants(3);

            Assert.AreEqual(first, a.ElementAt(0).Name);
            Assert.AreEqual(second, a.ElementAt(1).Name);
            Assert.AreEqual(secondLocation, a.ElementAt(1).Location);
            Assert.AreEqual(third, a.ElementAt(2).Name);

        }

        [TestMethod()]
        public void GetAllRestaurantsTest()
        {
            RestaurantsInfo infoObj = new RestaurantsInfo();
            int expectedRestaurantCount = 7;

            var a = infoObj.GetAllRestaurants();

            Assert.AreEqual(expectedRestaurantCount, a.Count());
            foreach (var restaurant in a)
            {
                Assert.IsNotNull(restaurant.Name);
            }
        }

        [TestMethod()]
        public void GetAllReviewsTest()
        {
            RestaurantsInfo infoObj = new RestaurantsInfo();
            Dummy d = new Dummy();
            int expectedReviewCount = d.GetReviewData().Count();

            var actualReviews = infoObj.GetAllReviews();

            Assert.AreEqual(expectedReviewCount, actualReviews.Count());
        }

        [TestMethod()]
        public void SearchRestaurantTest1()
        {
            RestaurantsInfo infoObj = new RestaurantsInfo();
            string expectedRestName = "Franklin BBQ";
            int expectedCount = 1;

            var a = infoObj.SearchRestaurant("Franklin BBQ");

            Assert.AreEqual(expectedCount, a.Count());
            Assert.AreEqual(expectedRestName, a.ElementAt(0).Name);
        }

        [TestMethod()]
        public void SearchRestaurantTest2()
        {
            string restPartialName = "chuck e";
            RestaurantsInfo infoObj = new RestaurantsInfo();
            string expectedRestName = "Chuck E. Cheese";
            int expectedCount = 1;

            var a = infoObj.SearchRestaurant(restPartialName);

            Assert.AreEqual(expectedCount, a.Count());
            Assert.AreEqual(expectedRestName, a.ElementAt(0).Name);
        }
    }
}