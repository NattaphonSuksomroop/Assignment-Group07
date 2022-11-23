using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.RestaurantSearch
{
    /// Interpreter design pattern

    public class RestaurantSearchDriver
    {
        public string RestaurantSearch()
        {
            InterpreterContext context = new InterpreterContext("Some API");
            RestaurantSearchClient client = new RestaurantSearchClient(context);
            Console.WriteLine("Search Restaurant");
            Console.WriteLine("Please Enter to see Restaurant:");
            var location = Console.ReadLine();
            string searchSentence = string.Format("restaurant by location '{0}'", location);
            var result = client.Intercept(searchSentence);
            
            if (!result.Any()) Console.WriteLine("Sorry, No Restaurants available in this location.");

            string restaurantId = string.Empty;

            if (result.Any())
            {
                Console.WriteLine("List of Restaurants");
                Console.WriteLine("*******************");

                foreach (var item in result)
                {
                    if(item.Queue != "Full")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("{0} {1}", item.RestaurantId, item.Name);
                        Console.WriteLine("{0}", item.Address);
                        int rating = item.Rating;
                        Console.Write("Rating: ");
                        while (rating > 0)
                        {
                            Console.Write("*");
                            rating--;
                        }

                        Console.WriteLine("Cuisine: {0}", item.Cuisine);
                        Console.WriteLine("_________________________________");
                    }
                    
                }

                Console.WriteLine();
                Console.WriteLine("Please Select Restaurant by Id: ");
                
                restaurantId = Console.ReadLine();
                
                    
                    
                
            }

            return restaurantId;
        }
        
    }
}
