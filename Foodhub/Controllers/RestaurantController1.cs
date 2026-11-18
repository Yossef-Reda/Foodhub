using Foodhub.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foodhub.Controllers
{
    public class Restaurant : Controller
    {
        private readonly List<Models.Restaurant> restaurants = new List<Models.Restaurant>()
        {
            new Models.Restaurant { Id = 1, Name = "Pizza Palace", Cuisine = "Italian", Rating = 4.5, DeliveryFee = 2.99m, DeliveryMinutes = 30, IsOpen = true },
            new Models.Restaurant { Id = 2, Name = "Sushi World", Cuisine = "Japanese", Rating = 4.8, DeliveryFee = 3.99m, DeliveryMinutes = 45, IsOpen = false },
            new Models.Restaurant { Id = 3, Name = "Burger Barn", Cuisine = "American", Rating = 4.2, DeliveryFee = 1.99m, DeliveryMinutes = 25, IsOpen = true },
            new Models.Restaurant { Id = 4, Name = "Taco Town", Cuisine = "Mexican", Rating = 4.0, DeliveryFee = 2.49m, DeliveryMinutes = 35, IsOpen = true },
            new Models.Restaurant { Id = 5, Name = "Curry Corner", Cuisine = "Indian", Rating = 4.6, DeliveryFee = 3.49m, DeliveryMinutes = 40, IsOpen = false }
        };
        public IActionResult Index()
        {
            var restaurant = restaurants.OrderByDescending(r => r.Rating).ToList();
            return View(restaurant);
        }
    }
}