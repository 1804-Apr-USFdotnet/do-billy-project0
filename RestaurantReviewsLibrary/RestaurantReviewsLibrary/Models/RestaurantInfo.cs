using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantReviewsLibrary.Abstracts;
using RestaurantReviewsLibrary.Interfaces;

namespace RestaurantReviewsLibrary.Models
{
    public class RestaurantInfo : Business, IRestaurantInfo
    {
        private List<IReview> ListOfReviews;
        private static int idCount = 1;

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
            Id = idCount++;
            ListOfReviews = new List<IReview>();
        }

        // Methods

        public int SubmitReview(string name, int rating, string description = "")
        {
            Review r = new Review(rating, this.Id, name, DateTime.Now, description);
            ListOfReviews.Add(r);
            return r.ReviewId;
        }

        public IEnumerable<IReview> GetAllReviews()
        {
            // copy of ListOfReviews?
            // ListOfReviews is private
            return ListOfReviews;
        }
    }
}
