using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantReviewsLibrary.Interfaces;

namespace RestaurantReviewsLibrary.Models
{
    public class Review : IReview
    {
        public int Rating { get; }
        public string ReviewerName { get; }
        public string Description { get; }
        public DateTime DateCreated { get; }

        // private default: Don't want to create a Review with no data
        private Review() { }

        public Review(int rating, string name, DateTime time, string description = "")
        {
            if (rating < 0)
            {
                Rating = 0;
            }
            else if (rating > 5)
            {
                Rating = 5;
            }
            ReviewerName = name;
            DateCreated = time;
            Description = description;
        }
    }
}
