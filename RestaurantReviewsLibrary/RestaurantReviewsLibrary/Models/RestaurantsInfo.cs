using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary.Models
{
    public class RestaurantsInfo
    {
        protected List<RestaurantInfo> _myList;

        public List<RestaurantInfo> List
        {
            get
            {
                return _myList;
            }
        }



        public RestaurantsInfo()
        {
            _myList = new List<RestaurantInfo>();
        }

        private void AddRestaurant(string name, string loc)
        {
            _myList.Add(new RestaurantInfo(name, loc));
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
