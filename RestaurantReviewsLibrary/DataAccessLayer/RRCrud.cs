using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RRCrud
    {
        RRDb db = new RRDb();

        // ============
        // CRUD Methods
        // ============

        // Create
        public int CreateRestaurant(string name, string loc) 
        {
            var restaurant = db.Restaurants.Create();
            restaurant.Name = name;
            restaurant.Location = loc;

            db.Restaurants.Add(restaurant);
            return db.SaveChanges();
        }

        public int CreateReview(int rating, string user, string desc, DateTime created, int restid) 
        {
            var review = db.Reviews.Create();
            review.Rating = rating;
            review.Username = user;
            review.Description = desc;
            review.DateCreated = created;

            review.RestaurantId = restid;

            db.Reviews.Add(review);
            return db.SaveChanges();
        }

        //Read
        public Restaurant ReadRestaurant()
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurant> GetAllRestarurants()
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public Review ReadReview()
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurant> GetAllReviews()
        {
            //TODO: Implement
            throw new NotImplementedException();
        }

        // Update

        // Delete

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
