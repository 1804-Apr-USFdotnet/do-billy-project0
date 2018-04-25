using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary.Models
{
    public class Dummy
    {
        private List<List<object>> _myRestaurantList;
        private List<List<object>> _myReviewList;

        public Dummy()
        {
            _myRestaurantList = new List<List<object>>();
            _myReviewList = new List<List<object>>();

            //populate list with dummy data
            _myRestaurantList.Add(new List<object> { "Pizza Place", "Tampa" });
            _myRestaurantList.Add(new List<object> { "Mission BBQ", "Tampa" });
            _myRestaurantList.Add(new List<object> { "Wendys", "Michigan" });
            _myRestaurantList.Add(new List<object> { "Franklin BBQ", "Austin, TX" });
            _myRestaurantList.Add(new List<object> { "Chuck E. Cheese", "California" });
            _myRestaurantList.Add(new List<object> { "Checkers", "Florida" });
            _myRestaurantList.Add(new List<object> { "Pizza Place", "Tallahassee" });

            _myReviewList.Add(new List<object> { 1, "Piper Doe" });
            _myReviewList.Add(new List<object> { 3, "Penelope Doe" });
            _myReviewList.Add(new List<object> { 4, "Pepper Potts" });
            _myReviewList.Add(new List<object> { 4, "Mary Jane" });
            _myReviewList.Add(new List<object> { 2, "Moses" });
            _myReviewList.Add(new List<object> { 3, "Wario" });
            _myReviewList.Add(new List<object> { 5, "Franklin" });
            _myReviewList.Add(new List<object> { 5, "Fartso Mcgee" });
            _myReviewList.Add(new List<object> { 1, "Chuuni Byou" });
            _myReviewList.Add(new List<object> { 2, "Child Name" });
            _myReviewList.Add(new List<object> { 1, "Check" });
            _myReviewList.Add(new List<object> { 1, "Charles" });
            _myReviewList.Add(new List<object> { 5, "John Doe" });
            _myReviewList.Add(new List<object> { 5, "John Doe" });
            _myReviewList.Add(new List<object> { 5, "John Doe" });
            _myReviewList.Add(new List<object> { 5, "John Doe" });
        }

        public List<List<object>> GetRestaruantData()
        {
            return _myRestaurantList;
        }

        public List<List<object>> GetReviewData()
        {

            return _myRestaurantList;
        }

        public void OutputSerialzedData()
        {
            //TODO
        }
    }
}
