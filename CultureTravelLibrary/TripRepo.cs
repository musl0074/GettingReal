using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureTravelLibrary
{
    public class TripRepo
    {
        private List<Trip> trips = new List<Trip>(1);

        public void CreateTrip(string tripName, string tripDate)
        {
            // If this is the first trip
            if (trips.Count == 0)
            {
                Trip t = new Trip(tripName, tripDate);
                trips.Add(t);
                Console.WriteLine("Rejsen er nu oprettet" + "\n");
                return;
            }

            // Check if trip already exists
            bool tripExists = false;
            for (int i = 0; i < trips.Count; i++)
            {
                if (trips[i].TripName == tripName)
                {
                    tripExists = true;
                    break;
                }
            }

            // If it doesnt exist, create the trip
            if (!tripExists)
            {
                Trip t = new Trip(tripName, tripDate);
                trips.Add(t);
                Console.WriteLine("Rejsen er nu oprettet" + "\n");
            }

            // If it does exists, respond with error message
            if (tripExists)
            {
                Console.WriteLine("Rejsen eksisterer allerede" + "\n");
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
