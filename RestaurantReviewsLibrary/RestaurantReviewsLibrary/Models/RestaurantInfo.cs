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

        public double AverageRating
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

        public RestaurantInfo(string name, string loc) : base(name, loc)
        {
        }

        public void SubmitReview(int rating, string name, string description = "")
        {
            ListOfReviews.Add(new Review(rating, name, DateTime.Now, description));
        }

        public List<IReview> GetAllReviews()
        {
            // copy of ListOfReviews?
            // ListOfReviews is private
            return ListOfReviews;
        }


    }
}
