using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantReviewsLibrary.Interfaces;
using System.Xml.Serialization;
using System.IO;
using DataAccessLayer;

namespace RestaurantReviewsLibrary.Models
{
    public class RestaurantsInfo : IRestaurantsInfo
    {
        private static string xmlFilename = @"RestaurantsInfo.xml";
        private static RRCrud test = new RRCrud();
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
            var tester = new RRCrud();
            tester.CreateRestaurant("Test Restaurant", "Earth");
            GetSerializedData();
            OutputToSerializedXml();
        }

        // -------
        // Methods
        // -------

        internal void AddRestaurant(string name, string loc)
        {
            _myList.Add(new RestaurantInfo(name, loc));
        }

        private void GetSerializedData()
        {
            if (File.Exists(xmlFilename))
            {
                TextReader txtReader = new StreamReader(xmlFilename);
                XmlSerializer x = new XmlSerializer(_myList.GetType());
                _myList = (List<RestaurantInfo>)x.Deserialize(txtReader);

                txtReader.Close();
            }
            else
            {
                Dummy d = new Dummy();
                foreach (var data in d.GetRestaruantData())
                {
                    AddRestaurant((string)data[0], (string)data[1]);
                }

                foreach (var review in d.GetReviewData())
                {
                    int restid = (int)review[0];
                    string name = (string)review[2];
                    int rating = (int)review[1];

                    if (!(review.Count() > 3))
                    {
                        _myList[restid].SubmitReview(name, rating);
                    }
                    else
                    {
                        _myList[restid].SubmitReview(name, rating, (string)review[3]);
                    }
                    
                }
            }
            
        }

        private void OutputToSerializedXml()
        {
            if (!File.Exists(xmlFilename))
            {
                XmlSerializer x = new XmlSerializer(_myList.GetType());
                TextWriter writer = new StreamWriter(xmlFilename);
                x.Serialize(writer, _myList);
            }
        }

        public IEnumerable<IRestaurantInfo> GetTopRestaurants(int n)
        {
            return _myList.OrderByDescending(c => c.GetAverageRating).Take(n);
        }

        public IEnumerable<IRestaurantInfo> GetTopThreeRestaurants()
        {
            return GetTopRestaurants(3);
        }

        public IEnumerable<IRestaurantInfo> GetAllRestaurants()
        {
            return _myList;
        }

        public IRestaurantInfo GetRestaurant(string name)
        {
            var obj = _myList.Find(c => c.Name == name);
            if (obj == null)
            {
                return null;
            }
            return obj;
        }

        public IEnumerable<IReview> GetAllReviews()
        {
            List<Review> retList = new List<Review>();
            foreach (var rest in _myList)
            {
                retList.AddRange(rest.ListOfReviews);
            }
            return retList;
        }

        public IEnumerable<IRestaurantInfo> SearchRestaurant(string searchQuery)
        {
            StringComparison comparison = StringComparison.InvariantCultureIgnoreCase;
            var obj = _myList.FindAll(c => c.Name.StartsWith(searchQuery, comparison));
            return obj;
        }
    }
}
