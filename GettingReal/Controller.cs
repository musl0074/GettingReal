using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CultureTravelLibrary;

namespace GettingReal
{
    public class Controller
    {
        private TripRepo tripRepo = new TripRepo();

        public void CreateTrip(string tripName, string tripDate)
        {
            tripRepo.CreateTrip(tripName, tripDate);
        }

        public void CreateTripCustomer(string firstName, string lastName, string plusOne, string streetName, string streetNumber, string zipCode, string city,
                                       string phoneNumber, string email, string roomType, string airport, string tripName)
        {
            Trip t = tripRepo.GetTrip(tripName);

            if (t != null)
            {
                t.CreateTripCustomer(firstName, lastName, plusOne, streetName, streetNumber, zipCode, city, phoneNumber, email, roomType, airport);
            }
            else
            {
                Console.WriteLine("Den angivet rejse eksisterer ikke" + "\n");
            }
        }

        public TripRepo GetTripRepo()
        {
            return tripRepo;
        }


        

    }
}
