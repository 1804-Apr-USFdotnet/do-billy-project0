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
    public class RestaurantInfoUnitTests
    {
        [TestMethod()]
        public void RestaurantInfoConstructorTest()
        {
            string expName = "Marv's Pizza Palace";
            string expLocation = "789 Thisisa Street";

            RestaurantInfo testObj = new RestaurantInfo(expName, expLocation);

            Assert.AreEqual(expName, testObj.Name);
            Assert.AreEqual(expLocation, testObj.Location);
            Assert.IsNotNull(testObj.Id);
        }

        [TestMethod()]
        public void RestaurantInfoGetAverageRatingTest1()
        {
            string expName = "Tatsuya Ramen";
            string expLocation = "123 Fake St.";
            double expRating = 0.0;

            RestaurantInfo testObj = new RestaurantInfo(expName, expLocation);

            Assert.AreEqual(expName, testObj.Name);
            Assert.AreEqual(expLocation, testObj.Location);
            Assert.AreEqual(expRating, testObj.GetAverageRating);
        }


        [TestMethod()]
        public void SubmitReviewTest()
        {
            string expReviewerName = "Hanzo Lastname";
            int expRating = 4;
            string expDesc = "";
            RestaurantInfo rest = new RestaurantInfo("name", "loc");

            int revId = rest.SubmitReview(expReviewerName, expRating);

            Assert.IsTrue(revId > 0);
        }

        [TestMethod()]
        public void GetAllReviewsTest()
        {
            string expName = "Restaurant1";
            string expLocation = "123 One St.";
            RestaurantInfo rest = new RestaurantInfo(expName, expLocation);

            var l = rest.GetAllReviews();

            Assert.Fail();
        }
    }
}