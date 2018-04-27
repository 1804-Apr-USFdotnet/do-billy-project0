﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary.Interfaces
{
    public interface IReview
    {
        int ReviewId { get; }
        int RestaurantId { get; }
        int Rating { get; }
        string ReviewerName { get; }
        string Description { get; }
        DateTime DateCreated { get; }
    }
}
