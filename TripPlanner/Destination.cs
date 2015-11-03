using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner
{
    // Basic class for storing destination information.
    class Destination
    {
        public string Name { get; set; }
        public Hotel[] Hotels { get; set; }
        public Attraction[] Attractions { get; set; }

        public Destination(string name, Hotel[] hotels, Attraction[] attractions)
        {
            Name = name;
            Hotels = hotels;
            Attractions = attractions;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
