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
        // fields
        private static int idCount = 1;

        // properties
        public int ReviewId { get; }
        public int Rating { get; }
        public int RestaurantId { get; }
        public string ReviewerName { get; }
        public string Description { get; }
        public DateTime DateCreated { get; }

        // Constructors
        private Review() { /* do not want default constrcutor */ }

        public Review(int rating, int restId, string name, DateTime time, string description = "")
        {
            ReviewId = idCount++;
            RestaurantId = restId;
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
