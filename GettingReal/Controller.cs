using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripLibrary;

namespace GettingReal
{
    public class Controller
    {
        private DBController dbControl = new DBController();
        private TripRepository tripRepo = new TripRepository();

        public void CreateTrip(string tripName, string tripDate)
        {
            dbControl.InsertTrip(tripName, tripDate);
        }

        public void CreateTripCustomer(string firstName, string lastName, string streetName, string streetNumber, string city, string zipCode,
                                       string phoneNumber, string email, string roomType, string airport, int Id)
        {  
            dbControl.InsertTripCustomer(firstName, lastName, streetName, streetNumber, city, zipCode, phoneNumber, email, roomType, airport, Id);
        }
        public void ShowTrips()
        {
            TripRepository updatedTripRepo = dbControl.ShowTrips();
            List<Trip> trips = updatedTripRepo.ShowTrips();
            for (int i = 0; i < trips.Count; i++)
            {
                Console.WriteLine(trips[i].Id + ". " + trips[i].Name + " " + trips[i].Date);
            }
        }


        public void ShowTripCustomers (int id)
        {
            Trip updatedTrip = dbControl.ShowTripCustomers(id);
            List<TripCustomer> tripCustomers = updatedTrip.ShowTripCustomers();

            for (int i = 0; i < tripCustomers.Count; i++)
            {
                Console.WriteLine(tripCustomers[i].Id + ". " + tripCustomers[i].FullName + ", " + tripCustomers[i].AddressInformation + ", " + tripCustomers[i].ContactInformation + ".");
            }
        }

        public void CreatePassport(string firstName, string lastName, string passportNumber, string dateOfIssue, string expireDate, string dateOfBirth, int customerPassID)
        {
            dbControl.InsertTripCustomerPassport(firstName, lastName, passportNumber, dateOfIssue, expireDate, dateOfBirth, customerPassID);
        }

        public void CreateTripCompanion(string companionFirstName, string companionLastName, int customerReferenceID)
        {
            dbControl.InsertTripCompanion(companionFirstName, companionLastName, customerReferenceID);
        }


        public void SpPrintList (int tripID)
        {
            TripRepository updatedTripRepo = dbControl.ShowTrip(tripID);
            List<Trip> trips = updatedTripRepo.ShowTrips();
            for (int i = 0; i < trips.Count; i++)
            {
                Console.WriteLine(trips[i].Name + " " + trips[i].Date);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("|    Fulde navn    ||      Ledsager     ||  Værelsestype  ||   Lufthavn   || Depositum || Restbeløb |");
            Trip trip = dbControl.SpPrintList(tripID);
            List<TripCustomer> tripCustomers = trip.ShowTripCustomers();
            for (int i = 0; i < tripCustomers.Count; i++)
            {
                Console.WriteLine("  " + tripCustomers[i].FullName + "    " + tripCustomers[i].Companion + "   " + tripCustomers[i].RoomType
                + "   " + tripCustomers[i].AirportName + "      " + tripCustomers[i].DepositeStatus + "          " + tripCustomers[i].BlanceStatus);
            }
        }

        public void DeleteTripList()
        {
            tripRepo.DeleteTripList();
        }


    }
}
