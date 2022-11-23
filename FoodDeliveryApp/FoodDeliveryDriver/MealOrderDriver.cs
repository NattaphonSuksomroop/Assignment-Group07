using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.OrderAndCancellation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.FoodDeliveryDriver
{
    public class MealOrderDriver
    {
        /// Command Design Pattern

        public char MealOrderByUser(List<FoodMenuModel> selectedMealItems, double totalCost, string restaurantId, out string orderId, out UserModel user)
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("Do you want to place order(y/n)...?");
            var wantsOrder = Console.ReadKey().KeyChar;
            Console.WriteLine(string.Empty);

            orderId = string.Empty;
            user = null;

            if (wantsOrder == 'y')
            {
                Console.WriteLine("_________________________");
                Food food = new Food();
                OrderFood orderFood = new OrderFood(food);
                orderFood.FoodItems = selectedMealItems;
                orderFood.User = new UserModel();
                orderFood.User.UserId = "63015158";
                orderFood.User.UserName = "Wasan Phuksongsri";
                orderFood.User.Address = "KMITL, Lad Krabang, Bangkok";
                orderFood.User.PhoneNumber = "0987654321";
                orderFood.User.Amount = totalCost;
                orderFood.RestaurantId = restaurantId;
                user = orderFood.User;
                Customer customer = new Customer();
                customer.TakeOrder(orderFood);
                customer.PlaceOrders();
                orderId = orderFood.OrderId;
                Console.WriteLine(string.Empty);
            }

            //Order Cancellation.
            char cancel = 'n';
            if (!string.IsNullOrEmpty(orderId))
            {
                Console.WriteLine("Do you want to cancel order(y/n)...?");
                cancel = Console.ReadKey().KeyChar;
                Console.WriteLine(string.Empty);

                if (cancel == 'y')
                {
                    Console.WriteLine(String.Empty);
                    Food food = new Food();
                    CancelFood cancelOrder = new CancelFood(food);
                    cancelOrder.OrderId = orderId;
                    Customer customer = new Customer();
                    customer.TakeOrder(cancelOrder);
                    customer.PlaceOrders();
                }
            }

            return cancel;
        }
    }
}
