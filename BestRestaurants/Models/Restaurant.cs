using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public List<Cuisine> Cuisines { get; set; }
    }
}