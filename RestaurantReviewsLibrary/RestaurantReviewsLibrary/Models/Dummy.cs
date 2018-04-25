using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary.Models
{
    class Dummy
    {
        private List<List<object>> _myList;

        public Dummy()
        {
            //populate list with dummy data
            _myList.Add(new List<object> { "Pizza Place", "Tampa" });
            _myList.Add(new List<object> { "Mission BBQ", "Tampa" });
            _myList.Add(new List<object> { "Wendys", "Michigan" });
            _myList.Add(new List<object> { "Franklin BBQ", "Austin, TX" });
            _myList.Add(new List<object> { "Chuck E. Cheese", "California" });
            _myList.Add(new List<object> { "Checkers", "Florida" });
            _myList.Add(new List<object> { "Pizza Place", "Tallahassee" });
        }

        public List<List<object>> GetData()
        {
            return _myList;
        }
    }
}
