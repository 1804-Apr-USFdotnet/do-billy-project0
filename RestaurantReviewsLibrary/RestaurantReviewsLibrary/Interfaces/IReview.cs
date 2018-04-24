﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary.Interfaces
{
    interface IReview
    {
        int Rating { get; }
        string ReviewerName { get; }
        string Description { get; }
        DateTime ReviewCreatedTime { get; }
    }
}