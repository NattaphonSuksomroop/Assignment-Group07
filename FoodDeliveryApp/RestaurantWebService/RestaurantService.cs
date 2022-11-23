using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.RestaurantWebService
{
    public class RestaurantService
    {
        public RestaurantService(string endPoint) {

        }
        public List<RestaurantModel> GetAllRestaurants()
        {
            List<RestaurantModel>  restaurants = new List<RestaurantModel>();
            restaurants.Add(new RestaurantModel { RestaurantId="001", Name="Thai Rosdee", Address="Lad Praw, Bangkok", Rating = 5 , Queue = "Medium", Cuisine = "Thai"});
            restaurants.Add(new RestaurantModel {RestaurantId="002", Name = "R Bang", Address = "Sam Yan, Bangkok",  Rating = 3 , Queue = "Few", Cuisine = "Indian" });
            restaurants.Add(new RestaurantModel {RestaurantId="003", Name = "Chinese Gooded", Address = "Yaowarach, Bangkok", Rating = 4, Queue = "Full",  Cuisine = "Chinese" });
            restaurants.Add(new RestaurantModel {RestaurantId="004", Name = "Western Mania", Address = "Thonburi, Bangkok", Rating =2, Queue = "Full", Cuisine = "Western" });
            restaurants.Add(new RestaurantModel {RestaurantId="005", Name = "Korean Styles", Address = "Lad Krabang, Bangkok", Rating = 4, Queue = "Medium", Cuisine = "Korean" });
            return restaurants;
        }
    }
}
