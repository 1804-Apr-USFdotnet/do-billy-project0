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
        private List<IReview> ListOfReviews;

        public double AverageRating
        {
            get
            {
                double sum = 0.0;
                foreach(IReview review in ListOfReviews)
                {
                    sum += review.Rating;
                }
                return sum / ListOfReviews.Count;
            }
        }

        public Restaurant(string name, string loc) : base(name, loc)
        {
        }

        public void SubmitReview(int rating, string name, string description = "")
        {
            ListOfReviews.Add(new review(rating, name, DateTime.Now, description));
        }

        public List<IReview> GetAllReviews()
        {
            // copy of ListOfReviews?
            // ListOfReviews is private
            return ListOfReviews;
        }


    }
}
