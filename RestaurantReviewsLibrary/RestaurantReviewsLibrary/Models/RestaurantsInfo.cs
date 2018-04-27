using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantReviewsLibrary.Interfaces;

namespace RestaurantReviewsLibrary.Models
{
    public class RestaurantsInfo : IRestaurantsInfo
    {
        // ----------
        // Properties
        // ----------
        protected List<RestaurantInfo> _myList;

        public IEnumerable<RestaurantInfo> ListOfRestaurants
        {
            get
            {
                return _myList;
            }
        }

        // ------------
        // Constructors
        // ------------
        public RestaurantsInfo()
        {
            _myList = new List<RestaurantInfo>();
        }

        // -------
        // Methods
        // -------

        internal void AddRestaurant(string name, string loc)
        {
            _myList.Add(new RestaurantInfo(name, loc));
        }

        public void GetTopAverageRatings()
        {
            //TODO: Implement
            _myList.OrderBy(c => c.GetAverageRating).Take(3);
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

        public void GetData()
        {
            //TODO: Make work with Serialized data, or database
            throw new NotImplementedException();
        }

        public IEnumerable<IRestaurantsInfo> GetTopRestaurants(int n)
        {
            //TODO: implement
            throw new NotImplementedException();
        }

        public IEnumerable<IRestaurantInfo> GetAllRestaurants()
        {
            //TODO: implement
            throw new NotImplementedException();
        }

        public IRestaurantInfo GetRestaurantDetail(int id)
        {
            //TODO: implement
            throw new NotImplementedException();
        }

        public IRestaurantInfo GetRestaurantDetail(string name)
        {
            //TODO: implement
            throw new NotImplementedException();
        }

        public IEnumerable<IReview> GetAllReviews()
        {
            //TODO: implement
            throw new NotImplementedException();
        }

        public IRestaurantInfo SearchRestaurant(string searchQuery)
        {
            //TODO: implement
            throw new NotImplementedException();
        }
    }
}
