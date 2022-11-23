using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.RestaurantFoodMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.FoodDeliveryDriver
{
    /// Iterator Pattern.

    public class MealMenuIteratorDriver
    {
        
        public List<FoodMenuModel> PrintMealMenu(string restaurantId)
        {
            
            Waitress waitress = new Waitress(restaurantId);
            var foodMenu = waitress.PrintFoodMenu();
            
            return foodMenu;
        }
    }
}
