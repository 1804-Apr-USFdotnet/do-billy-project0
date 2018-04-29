using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantReviewsLibrary.Interfaces;

namespace RestaurantReviewsLibrary.Models
{
    [Serializable]
    public class Review : IReview
    {

        // properties
        public int Rating { get; }
        public string ReviewerName { get; }
        public string Description { get; }
        public DateTime DateCreated { get; }

        // Constructors
        private Review() { /* do not want default constrcutor */ }

        public Review(int rating, string name, DateTime time, string description = "")
        {
            if (rating <= 0)
            {
                Rating = 0;
            }
            else
            {
                Rating = Math.Min(5, rating);
                
            }
            ReviewerName = name;
            DateCreated = time;
            Description = description;
        }
    }
}
