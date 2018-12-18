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
            dbControl.ShowTrips();
            List<Trip> trips = tripRepo.ShowTrips();
            for (int i = 0; i < trips.Count; i++)
            {
                Console.WriteLine(trips[i].Id + ". " + trips[i].Name + " " + trips[i].Date);
            }
        }


        public void ShowTripCustomers (int id)
        {
            dbControl.ShowTripCustomers(id);
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
            dbControl.ShowTrip(tripID);
            dbControl.SpPrintList(tripID);
        }

        public void DeleteTripList()
        {
            tripRepo.DeleteTripList();
        }


    }
}
