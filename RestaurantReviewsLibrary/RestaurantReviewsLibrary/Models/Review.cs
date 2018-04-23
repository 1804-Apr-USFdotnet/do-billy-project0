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
        public DateTime ReviewCreatedTime { get; }
    }
}
