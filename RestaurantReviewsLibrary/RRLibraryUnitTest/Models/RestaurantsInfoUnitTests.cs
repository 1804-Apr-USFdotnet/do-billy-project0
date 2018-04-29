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
        public void GetTopAverageRatingsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetSerializedDataTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDataTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTopRestaurantsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllRestaurantsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetRestaurantDetailTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetRestaurantDetailTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllReviewsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchRestaurantTest()
        {
            Assert.Fail();
        }
    }
}