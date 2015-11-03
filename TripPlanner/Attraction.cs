using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner
{
    // Basic class for storing attraction information.
    class Attraction
    {
        public string Name { get; set; }
        public Image Picture { get; set; }

        public Attraction(string name, Image picture)
        {
            Name = name;
            Picture = picture;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
