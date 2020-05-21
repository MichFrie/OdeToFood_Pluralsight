using OdeToFoot.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {

            restaurants = new List<Restaurant>()
            {
                new Restaurant{ID = 1, Name="Scotts Pizza", Location="Maryland", Cuisine=CuisineType.Indian},
                new Restaurant{ID = 2, Name="Chads Pizza", Location="Alabama", Cuisine=CuisineType.Mexican},
                new Restaurant{ID = 3, Name="Tims Pizza", Location="Iowa", Cuisine=CuisineType.Italian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
