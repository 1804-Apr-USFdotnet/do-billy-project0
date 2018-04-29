using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantReviewsLibrary.Interfaces;
using System.Xml.Serialization;
using System.IO;

namespace RestaurantReviewsLibrary.Models
{
    public class RestaurantsInfo : IRestaurantsInfo
    {
        private string xmlFilename = @"Data\RestaurantsInfo.xml";
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
            GetSerializedData();
        }

        // -------
        // Methods
        // -------

        internal void AddRestaurant(string name, string loc)
        {
            _myList.Add(new RestaurantInfo(name, loc));
        }

        public IEnumerable<IRestaurantInfo> GetTopAverageRatings()
        {
            return _myList.OrderBy(c => c.GetAverageRating).Take(3);
            //throw new NotImplementedException();
            
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

        private void OutputToSerializedXml()
        {
            if (!File.Exists(xmlFilename))
            {
                XmlSerializer x = new XmlSerializer(this.GetType());
                TextWriter writer = new StreamWriter(xmlFilename);
                x.Serialize(writer, this);
            }
            
        }

        public void GetData()
        {
            //TODO: Make work with Serialized data, or database
            if (File.Exists())
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
