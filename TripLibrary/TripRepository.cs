using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public class TripRepository
    {
        private List<Trip> trips = new List<Trip>();
        private Trip trip = new Trip();

        public void CreateTrips(string id, string tripName, string tripDate)
        {
            Trip t = new Trip(id, tripName, tripDate);
            trips.Add(t);
        }

        public void CreateTrip(string tripName, string tripDate)
        {
            Trip t = new Trip(tripName, tripDate);
            trip = t;
        }

        public Trip GetTrip(string tripName, string tripDate)
        {
            for (int i = 0; i < trips.Count; i++)
            {
                if (trips[i].TripName == tripName && trips[i].TripDate == tripDate)
                {
                    return trips[i];
                }
            }
            return null;
        }

        public List<Trip> ShowTrips()
        {
            return trips;
        }

        public Trip ShowTrip()
        {
            return trip;
        }

        public void DeleteTripList()
        {
          
            trips.Clear();
            
        }
    }
}
