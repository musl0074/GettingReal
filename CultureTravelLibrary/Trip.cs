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
        

        public void CreateTripCustomer (string name, string plusOne, string address, string zipCode, string city,
                                       string phoneNumber, string email, string roomType, string airport)
        {
            foreach (TripCustomer tripCustomer in tripCustomers)
            {
                if (tripCustomer.PhoneNumber != phoneNumber)
                {
                    TripCustomer c = new TripCustomer(name, plusOne, address,
                                                      zipCode, city, phoneNumber,
                                                      email, roomType, airport);

                    Console.WriteLine("Den rejsende er nu registeret til rejsen");
                }
                else
                {
                    Console.WriteLine("Den rejsende er allerede registeret på rejsen");
                }
            }
        }

    }
}
