using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
  public class RestaurantsContext : DbContext
  {
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Cuisine> Cuisines { get; set; }

    public RestaurantsContext(DbContextOptions options) : base(options) { }


  }

}