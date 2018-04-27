using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary.Interfaces
{
    public interface IRestaurantsInfo
    {
        IEnumerable<IRestaurantsInfo> GetTopRestaurants(int n);
        IEnumerable<IRestaurantInfo> GetAllRestaurants();
        IRestaurantInfo GetRestaurantDetail(int id);
        IRestaurantInfo GetRestaurantDetail(string name);
        IEnumerable<IReview> GetAllReviews();
        IRestaurantInfo SearchRestaurant(string searchQuery);
    }
}
