﻿using System;
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
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter writer = new StreamWriter(Path.Combine(myDocPath, "KundeInformation.txt")))
            {
                writer.WriteLine("bap min lange herr");
            }
            dbControl.InsertTripCustomerPassport(firstName, lastName, passportNumber, dateOfIssue, expireDate, dateOfBirth, customerPassID);
        }

        public void CreateTripCompanion(string companionFirstName, string companionLastName, int customerReferenceID)
        {
            dbControl.InsertTripCompanion(companionFirstName, companionLastName, customerReferenceID);
        }


        public void SpPrintList (int tripID)
        {
            TripRepository updatedTripRepo = dbControl.ShowTrip(tripID);
            Trip trip = updatedTripRepo.ShowTrip();
            string tripName = trip.Name + " " + trip.Date;
            Console.WriteLine(tripName);
            Console.WriteLine();
            Console.WriteLine();
            string collums = "|    Fulde navn    ||   Lufthavn   ||  Værelsestype  || Depositum || Restbeløb ||      Ledsager     |";
            Console.WriteLine(collums);
            dbControl.SpPrintList(tripID);
            List<TripCustomer> tripCustomers = trip.ShowTripCustomers();
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
                    writer.WriteLine("   " + tripCustomer.FullName + "        "
                                 + tripCustomer.RoomType + "      " + tripCustomer.AirportName + "        " +
                                 tripCustomer.DepositeStatus + "          " + tripCustomer.BlanceStatus + "         " + tripCustomer.Companion);
                }
                
            }
        }

        public void DeleteTripList()
        {
            dbControl.DeleteTrips();
        }
    }
}
