using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureTravelLibrary
{
    public class TripRepo
    {
        private List<Trip> trips = new List<Trip>();

        public void CreateTrip(string tripName, string tripDate)
        {
            Trip t = new Trip(tripName, tripDate);
            trips.Add(t);
        }

        public List<Trip> ShowTrips ()
        {
            return trips;
        }

    }
}
