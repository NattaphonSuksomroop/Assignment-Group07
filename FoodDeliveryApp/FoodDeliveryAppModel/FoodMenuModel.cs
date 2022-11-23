using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.FoodDeliveryAppModel
{
    public class FoodMenuModel
    {
        //รหัสร้านอาหาร
        private string restaurantId;
        public string RestaurantId
        {
            get { return restaurantId; }
            set { restaurantId = value; }
        }
        //รหัสอาหาร
        private string foodId;
        public string FoodId
        {
            get { return foodId; }
            set { foodId = value; }
        }
        //ชื่ออาหาร
        private string foodname;
        public string FoodName
        {
            get { return foodname; }
            set { foodname = value; }
        }
        //สัญชาติอาหาร
        private string cuisine;
        public string Cuisine
        {
            get { return cuisine; }
            set { cuisine = value; }
        }
        //ราคา
        private double rate;
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        //ราคา
        private int rating;
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
