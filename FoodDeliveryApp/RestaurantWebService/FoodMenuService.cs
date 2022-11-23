using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.RestaurantSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.RestaurantWebService
{
    public class FoodMenuService
    {
        public FoodMenuService(string endPoint, string restaurantId)
        {
            //RestaurantSearchDriver restaurantSearchDriver = new RestaurantSearchDriver();
            }

        public List<FoodMenuModel> getAllFoodMenu(string restaurantId)
        {
            
            
                List<FoodMenuModel> foodMenu = new List<FoodMenuModel>();
            if (restaurantId == "001")
            {
                foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "001", Cuisine = "Thai", FoodName = "Hang-le curry", Rating = 5, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "002", Cuisine = "Thai", FoodName = "Papaya salad", Rating = 4, Rate = 300 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "003", Cuisine = "Thai", FoodName = "Roast chicken", Rating = 5, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "004", Cuisine = "Thai", FoodName = "Spicy minced beef", Rating = 3, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "005", Cuisine = "Thai", FoodName = "Steamed chicken with rice", Rating = 5, Rate = 100 });

                return foodMenu;
            }
            if (restaurantId == "002")
            {
                foodMenu.Add(new FoodMenuModel { RestaurantId = "002", FoodId = "002", Cuisine = "Indian", FoodName = "Chicken Korma", Rating = 4, Rate = 300 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "002", FoodId = "003", Cuisine = "Indian", FoodName = "Shahi Paneer", Rating = 5, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "002", FoodId = "004", Cuisine = "Indian", FoodName = "Tandoori Roti", Rating = 3, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "002", FoodId = "005", Cuisine = "Indian", FoodName = "Choley Bhaturey", Rating = 5, Rate = 100 });
                return foodMenu;
            }
            if (restaurantId == "003")
            {
                foodMenu.Add(new FoodMenuModel { RestaurantId = "003", FoodId = "001", Cuisine = "Chinese", FoodName = "Tang Cu Pai Gu", Rating = 5, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "003", FoodId = "002", Cuisine = "Chinese", FoodName = "Gong Bao Ji Ding", Rating = 4, Rate = 300 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "003", FoodId = "003", Cuisine = "Chinese", FoodName = "Chun Juan", Rating = 5, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "003", FoodId = "004", Cuisine = "Chinese", FoodName = "Chao Fan", Rating = 3, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "003", FoodId = "005", Cuisine = "Chinese", FoodName = "Ma Po Dou Fu", Rating = 5, Rate = 100 });

                return foodMenu;
            }
            if (restaurantId == "004")
            {
                foodMenu.Add(new FoodMenuModel { RestaurantId = "004", FoodId = "001", Cuisine = "Western", FoodName = "sandwich", Rating = 5, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "004", FoodId = "002", Cuisine = "Western", FoodName = "bacon and eggs", Rating = 4, Rate = 300 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "004", FoodId = "003", Cuisine = "Western", FoodName = "stew", Rating = 5, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "004", FoodId = "004", Cuisine = "Western", FoodName = "cheeseburger", Rating = 3, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "004", FoodId = "005", Cuisine = "Western", FoodName = "fillet steak", Rating = 5, Rate = 100 });

                return foodMenu;
            }
            if (restaurantId == "005")
            {
                foodMenu.Add(new FoodMenuModel { RestaurantId = "005", FoodId = "001", Cuisine = "Korean", FoodName = "Bibimbap", Rating = 5, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "005", FoodId = "002", Cuisine = "Korean", FoodName = "Bibim-milmyeon", Rating = 4, Rate = 300 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "005", FoodId = "003", Cuisine = "Korean", FoodName = "Bindae-tteok", Rating = 5, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "005", FoodId = "004", Cuisine = "Korean", FoodName = "Bulgogi", Rating = 3, Rate = 250 });
                foodMenu.Add(new FoodMenuModel { RestaurantId = "005", FoodId = "005", Cuisine = "Korean", FoodName = "Bungeo-ppang", Rating = 5, Rate = 100 });

                return foodMenu;
            }
            return foodMenu;
        }
    }
}
