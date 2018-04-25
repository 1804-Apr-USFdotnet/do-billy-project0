using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary.Models
{
    public class RestaurantsList
    {
        protected List<Restaurant> _myList;

        public List<Restaurant> List
        {
            get
            {
                return _myList;
            }
        }



        public RestaurantsList()
        {
            _myList = new List<Restaurant>();
        }

        private void AddRestaurant(string name, string loc)
        {
            _myList.Add(new Restaurant(name, loc));
        }

        public void GetTopAverageRatings()
        {
            //TODO
            _myList.OrderBy(c => c.AverageRating).Take(3);
            throw new NotImplementedException();
            
        }

        public void GetSerializedData()
        {
            // Intends to get data from serialized data, and populate the list of restaurants
            // TODO: probably shouldn't be here? Delete?
            Dummy d = new Dummy();
            foreach (var data in d.GetRestaruantData())
            {
                AddRestaurant((string)data[0], (string)data[1]);
            }

        }

    }
}
