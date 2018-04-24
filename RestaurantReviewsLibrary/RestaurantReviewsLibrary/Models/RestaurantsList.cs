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

        private void AddRestaurant()
        {

        }

        private void GetSerializedData()
        {
            // Intends to get data from serialized data, and populate the list of restaurants
            // TODO: probably shouldn't be here? Delete?
        }

        private void OutputSerializedData()
        {
            //create data, then serialize it to JSON
        }
    }
}
