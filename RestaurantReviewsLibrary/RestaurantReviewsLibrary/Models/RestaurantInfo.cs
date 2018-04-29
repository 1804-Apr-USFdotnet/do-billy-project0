using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

using RestaurantReviewsLibrary.Abstracts;
using RestaurantReviewsLibrary.Interfaces;

namespace RestaurantReviewsLibrary.Models
{
    [DataContract]
    public class RestaurantInfo : Business, IRestaurantInfo
    { 
        [DataMember]
        private List<IReview> ListOfReviews;

        // Properties
        public double GetAverageRating
        {
            get
            {
                if (!(ListOfReviews.Count > 0))
                {
                    return 0;
                }
                double sum = 0.0;
                foreach(IReview review in ListOfReviews)
                {
                    sum += review.Rating;
                }
                return sum / ListOfReviews.Count;
            }
        }

        public int ReviewCount
        {
            get
            {
                return ListOfReviews.Count;
            }
        }

        // Constructors
        private RestaurantInfo(): base() { /* do not implement */ }

        public RestaurantInfo(string name, string loc) : base(name, loc)
        {
            ListOfReviews = new List<IReview>();
        }

        // Methods
        public void SubmitReview(string name, int rating, string description = "")
        {
            Review r = new Review(rating, name, DateTime.Now, description);
            ListOfReviews.Add(r);
        }

        public IEnumerable<IReview> GetAllReviews()
        {
            // copy of ListOfReviews?
            // ListOfReviews is private
            return ListOfReviews;
        }
    }
}
