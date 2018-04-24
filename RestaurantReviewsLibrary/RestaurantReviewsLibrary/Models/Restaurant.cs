using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantReviewsLibrary.Abstracts;
using RestaurantReviewsLibrary.Interfaces;

namespace RestaurantReviewsLibrary.Models
{
    class Restaurant : Business, IRestaurant
    {
        List<IReview> ListOfReviews { get; }

        public double AverageRating
        {
            get
            {
                return 0;
            }
        }
    }
}
