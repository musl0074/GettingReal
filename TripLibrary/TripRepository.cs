using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public class TripRepository
    {
        public List<Trip> trips = new List<Trip>();

        public void CreateTrips(int Id, string tripName, string tripDate)
        {
            Trip t = new Trip(Id, tripName, tripDate);
            trips.Add(t);
        }

        public void CreateTrip(string tripName, string tripDate)
        {
            Trip t = new Trip(tripName, tripDate);
            trips.Add(t);
        }

        public Trip GetTrip(string tripName, string tripDate)
        {
            for (int i = 0; i < trips.Count; i++)
            {
                if (trips[i].Name == tripName && trips[i].Date == tripDate)
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

        public void DeleteTripList()
        {
          
            trips.Clear();
            
        }
    }
}
