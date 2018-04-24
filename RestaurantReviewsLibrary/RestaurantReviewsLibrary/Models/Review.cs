using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantReviewsLibrary.Interfaces;

namespace RestaurantReviewsLibrary.Models
{
    public class review : IReview
    {
        public int Rating { get; }
        public string ReviewerName { get; }
        public string Description { get; }
        public DateTime ReviewCreatedTime { get; }

        // private default: Don't want to create a Review with no data
        private review() { }

        public review(int rating, string name, DateTime time, string description = "")
        {
            // TODO: Check for correct rating range (1-5?)
            Rating = rating;
            ReviewerName = name;
            ReviewCreatedTime = time;
            Description = description;
        }
    }
}
