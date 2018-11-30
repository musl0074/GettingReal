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

            foreach (Trip trip in trips)
            {
                if (trip.TripName != tripName)
                {
                    Trip t = new Trip(tripName, tripDate);
                    trips.Add(t);
                }
                else
                {
                    Console.WriteLine("Rejsen eksistere allerede");
                }
            }

            

           
        }

        public List<Trip> ShowTrips ()
        {
            return trips;
        }

        public Trip GetTrip(string tripName)
        {
            Trip tripToReturn = null;
            foreach  (Trip trip in trips)
            {
                if (trip.TripName == tripName)
                {
                    tripToReturn = trip;
                }
            }
            return tripToReturn;
        }

    }
}
