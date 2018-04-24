using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantReviewsLibrary.Abstracts;
using RestaurantReviewsLibrary.Interfaces;

namespace RestaurantReviewsLibrary.Models
{
    public class Restaurant : Business, IRestaurant
    {
        List<IReview> ListOfReviews { get; }

        public double AverageRating
        {
            get
            {
                double total = 0.0;
                int count = 0;
                foreach(IReview review in ListOfReviews)
                {
                    total += review.Rating;
                    ++count;
                }
                return total / count;
            }
        }

        public Restaurant(string name, string loc)
        {

        }

        public void SubmitReview(int rating, string name, string description = "")
        {
            ListOfReviews.Add(new review(rating, name, DateTime.Now, description));
        }


    }
}
