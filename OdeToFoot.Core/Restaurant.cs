using OdeToFoot.Core;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;


namespace OdeToFoot.Core
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public CuisineType Cuisine { get; set; }

    }
}
