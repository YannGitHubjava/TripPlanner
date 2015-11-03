using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner
{
    // Basic class for storing information about a trip.
    class Trip
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Destination Destination { get; set; }
        public Hotel Hotel { get; set; }

        public Trip(DateTime startDate, DateTime endDate, Destination destination, Hotel hotel)
        {
            StartDate = startDate;
            EndDate = endDate;
            Destination = destination;
            Hotel = hotel;
        }
    }
}
