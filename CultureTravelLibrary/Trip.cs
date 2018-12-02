using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureTravelLibrary
{
    public class Trip
    {
        private List<TripCustomer> tripCustomers = new List<TripCustomer>();

        public string TripName { get; set; }
        public string TripDate { get; set; }

        public Trip(string tripName, string tripDate)
        {
            TripName = tripName;
            TripDate = tripDate;
        }
        

        public List<TripCustomer> GetTripCustomers ()
        {
            return tripCustomers;
        }

        public void CreateTripCustomer (string name, string plusOne, string address, string zipCode, string city,
                                       string phoneNumber, string email, string roomType, string airport)
        {
            // If it is the first to be added
            if (tripCustomers.Count == 0)
            {
                TripCustomer c = new TripCustomer(name, plusOne, address,
                                                  zipCode, city, phoneNumber,
                                                  email, roomType, airport);
                tripCustomers.Add(c);

                Console.WriteLine("Den rejsende er nu registeret til rejsen" + "\n");
                return; 
            }

            // Check if customer already exists
            bool customerExists = false;
            for (int i = 0; i < tripCustomers.Count; i++)
            {
                if (tripCustomers[i].PhoneNumber == phoneNumber)
                {
                    customerExists = true;
                    Console.WriteLine("Den rejsende er allerede registeret til rejsen" + "\n");
                }
            }

            if (!customerExists)
            {
                TripCustomer c = new TripCustomer(name, plusOne, address,
                                                  zipCode, city, phoneNumber,
                                                  email, roomType, airport);
                tripCustomers.Add(c);

                Console.WriteLine("Den rejsende er nu registeret til rejsen" + "\n");
            }
        }
    }
}
