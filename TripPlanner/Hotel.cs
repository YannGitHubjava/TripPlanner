using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner
{
    // Basic class for storing hotel information.
    class Hotel
    {
        public string Name { get; set; }
        public int Stars { get; set; }
        public decimal Price { get; set; }
        public Image Picture { get; set; }

        public Hotel(string name, int stars, decimal price, Image picture)
        {
            Name = name;
            Stars = stars;
            Price = price;
            Picture = picture;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
