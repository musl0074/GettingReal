using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripLibrary;
using System.IO;

namespace GettingReal
{
    public class Controller
    {
        private DBController dbControl = new DBController();
        

        public void CreateTrip(string tripName, string tripDate)
        {
            dbControl.InsertTrip(tripName, tripDate);
        }

        public void CreateTripCustomer(string firstName, string lastName, string streetName, string streetNumber, string cityName, string zipCode,
                                       string phoneNumber, string email, string roomType, string airportName, int id)
        {  
            dbControl.InsertTripCustomer(firstName, lastName, streetName, streetNumber, cityName, zipCode, phoneNumber, email, roomType, airportName, id);
        }
        public void ShowTrips()
        {
            TripRepository updatedTripRepo = dbControl.ShowTrips();
            List<Trip> trips = updatedTripRepo.ShowTrips();
            for (int i = 0; i < trips.Count; i++)
            {
                Console.WriteLine(trips[i].Id + ". " + trips[i].TripName + " " + trips[i].TripDate);
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

        public void CreatePassport(string passportNumber, string dateOfIssue, string expireDate, string dateOfBirth, int customerPassID)
        {
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter writer = new StreamWriter(Path.Combine(myDocPath, "KundeInformation.txt")))
            {
                writer.WriteLine("placeholder");
            }
            dbControl.InsertTripCustomerPassport(passportNumber, dateOfIssue, expireDate, dateOfBirth, customerPassID);
        }

        public void CreateTripCompanion(string companionFirstName, string companionLastName, int customerReferenceID)
        {
            dbControl.InsertTripCompanion(companionFirstName, companionLastName, customerReferenceID);
        }


        public void SpPrintList (int tripID)
        {
            TripRepository updatedTripRepo = dbControl.ShowTrip(tripID);
            Trip trip = updatedTripRepo.ShowTrip();
            string tripName = trip.TripName + " " + trip.TripDate;
            Console.WriteLine(tripName);
            Console.WriteLine();
            Console.WriteLine();
            string collums = "|    Fulde navn    ||   Lufthavn   ||  Værelsestype  || Depositum || Restbeløb ||      Ledsager     |";
            Console.WriteLine(collums);
            Trip trip2 = dbControl.SpPrintList(tripID);
            List<TripCustomer> tripCustomers = trip2.ShowTripCustomers();
            string customers = "";
            for (int i = 0; i < tripCustomers.Count; i++)
            {
                customers += "   " + tripCustomers[i].FullName + "        " 
                                 + tripCustomers[i].RoomType + "      " + tripCustomers[i].AirportName + "        " + 
                                 tripCustomers[i].DepositeStatus + "          " + tripCustomers[i].BlanceStatus + "         " + tripCustomers[i].Companion + "\n";
            }
            Console.WriteLine(customers);
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter writer = new StreamWriter(Path.Combine(myDocPath, "KundeInformation.txt")))
            {
                writer.WriteLine(tripName);
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine(collums);
                foreach (TripCustomer tripCustomer in tripCustomers)
                {
                    writer.WriteLine("   " + tripCustomer.FullName + "        " + tripCustomer.RoomType + 
                                    "      " + tripCustomer.AirportName + "        " + tripCustomer.DepositeStatus + 
                                    "          " + tripCustomer.BlanceStatus + "         " + tripCustomer.Companion);  
                }
                
            }
        }

        public void DeleteTripList()
        {
            dbControl.DeleteTrips();
        }

        public void Deposit(string answer, int ID)
        {
            dbControl.InsertDeposit(answer, ID);
        }

        public void Balance(string answer, int ID)
        {
            dbControl.InsertBalance(answer, ID);
        }

        public void SpPrintPassInfo(int ID)
        {
            TripRepository updatedTripRepo = dbControl.ShowTrip(ID);
            Trip trip = updatedTripRepo.ShowTrip();
            string tripName = trip.TripName + " " + trip.TripDate;
            Console.WriteLine(tripName);
            Console.WriteLine();
            Console.WriteLine();
            string collums = "|   Fulde navn   ||  Passport Number  || Date of issue || Expire date || Date of birth |";
            Console.WriteLine(collums);
            Trip trip2 = dbControl.SpPrintPassport(ID);
            List<TripCustomer> tripCustomers = trip2.ShowTripCustomers();
            string customers = "";
            for (int i = 0; i < tripCustomers.Count; i++)
            {
                customers += "   " + tripCustomers[i].FullName + "          "
                                 + tripCustomers[i].PassportNumber + "         " + tripCustomers[i].DateOfIssue + "       " +
                                 tripCustomers[i].ExpiredDate + "     " + tripCustomers[i].DateOfBirth + "\n";
            }
            Console.WriteLine(customers);
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter writer = new StreamWriter(Path.Combine(myDocPath, "PasInformation.txt")))
            {
                writer.WriteLine(tripName);
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine(collums);
                foreach (TripCustomer tripCustomer in tripCustomers)
                {
                    writer.WriteLine("   " + tripCustomer.FullName + "          "
                                 + tripCustomer.PassportNumber + "         " + tripCustomer.DateOfIssue + "       " +
                                 tripCustomer.ExpiredDate + "     " + tripCustomer.DateOfBirth);
                }

            }
        }

        public void DeleteTripCustomers()
        {
            dbControl.DeleteTripCustomers();
        }
    }
}