﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Menu
    {
        private Controller control = new Controller();
        public void Show()
        {
            bool running = true;
            do
            {
                Console.Clear();
                ShowMenu();
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "0":
                        running = false;
                        break;
                    case "1":
                        Console.Clear();
                        TripMenu();
                        break;
                    case "2":
                        Console.Clear();
                        TripCustomerMenu();                       
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadLine();
                        break;
                }
            } while (running);
        }

        private void ShowMenu()
        {

            string title = @"   _____                                   _  __     _ _                       _               
  / ____|                                 | |/ /    | | |                     (_)              
 | |     _ __ __ _ _ __ ___   ___  _ __   | ' /_   _| | |_ _   _ _ __ _ __ ___ _ ___  ___ _ __ 
 | |    | '__/ _` | '_ ` _ \ / _ \| '_ \  |  <| | | | | __| | | | '__| '__/ _ \ / __|/ _ \ '__|
 | |____| | | (_| | | | | | | (_) | | | | | . \ |_| | | |_| |_| | |  | | |  __/ \__ \  __/ |   
  \_____|_|  \__,_|_| |_| |_|\___/|_| |_| |_|\_\__,_|_|\__|\__,_|_|  |_|  \___| |___/\___|_|   
                                                                             _/ |              
                                                                            |__/  ";
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine("1. Kulturrejser");
            Console.WriteLine("2. Kunder");
            Console.WriteLine("0. Exit");
        }
        
        private void TripMenu()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                string title = @"   _____                                   _  __     _ _                       _               
  / ____|                                 | |/ /    | | |                     (_)              
 | |     _ __ __ _ _ __ ___   ___  _ __   | ' /_   _| | |_ _   _ _ __ _ __ ___ _ ___  ___ _ __ 
 | |    | '__/ _` | '_ ` _ \ / _ \| '_ \  |  <| | | | | __| | | | '__| '__/ _ \ / __|/ _ \ '__|
 | |____| | | (_| | | | | | | (_) | | | | | . \ |_| | | |_| |_| | |  | | |  __/ \__ \  __/ |   
  \_____|_|  \__,_|_| |_| |_|\___/|_| |_| |_|\_\__,_|_|\__|\__,_|_|  |_|  \___| |___/\___|_|   
                                                                             _/ |              
                                                                            |__/  ";
                Console.WriteLine(title);
                Console.WriteLine("1. Opret Rejse");
                Console.WriteLine("2. Vis tilmeldte til rejse");
                Console.WriteLine("3. Gå tilbage til menu");
                string input = GetUserChoice();

                switch (input)
                {
                    case "1":
                        CreateTrip();
                        break;
                    case "2":
                        ShowTripCustomer();
                        break;
                    case "3":
                        Show();
                        break;

                    default:
                        break;
                }
            }
            
        }

        private void TripCustomerMenu ()
        {
            bool running = true;
            while (running)
            {

                Console.Clear();
                string title = @"   _____                                   _  __     _ _                       _               
  / ____|                                 | |/ /    | | |                     (_)              
 | |     _ __ __ _ _ __ ___   ___  _ __   | ' /_   _| | |_ _   _ _ __ _ __ ___ _ ___  ___ _ __ 
 | |    | '__/ _` | '_ ` _ \ / _ \| '_ \  |  <| | | | | __| | | | '__| '__/ _ \ / __|/ _ \ '__|
 | |____| | | (_| | | | | | | (_) | | | | | . \ |_| | | |_| |_| | |  | | |  __/ \__ \  __/ |   
  \_____|_|  \__,_|_| |_| |_|\___/|_| |_| |_|\_\__,_|_|\__|\__,_|_|  |_|  \___| |___/\___|_|   
                                                                             _/ |              
                                                                            |__/  ";
                Console.WriteLine(title);
                Console.WriteLine("1. Opret Kunde");
                Console.WriteLine("2. Opdater Kunde");
                Console.WriteLine("3. Gå tilbage til menu");
                string input = GetUserChoice();

                switch (input)
                {
                    case "1":
                        CreateTripCustomer();
                        break;

                    case "2":
                        Console.Clear();
                        UpdateTripCustomer();
                        break;

                    default:
                        break;
                }
            }
        }

        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }

        private void CreateTrip()
        {
            Console.Write("Indtast navn på rejse: ");
            string tripName = Console.ReadLine();
            Console.Write("Indtast dato for rejsen: ");
            string tripDate = Console.ReadLine();
            control.CreateTrip(tripName, tripDate);

            Console.WriteLine("Tryk 'Enter' for at komme tilbage til menuen");
            Console.Read();
        }

        private void CreateTripCustomer()
        {
            Console.WriteLine("Liste over rejser.");
            Console.WriteLine();
            control.GetTrips();
            Console.WriteLine();
            Console.WriteLine("Vælg rejse du vil tilføje kunde til.");
            string tripId = Console.ReadLine();
            int Id = Convert.ToInt32(tripId);
            Console.Clear();
            Console.Write("Indtast fornavn på deltager: ");
            string firstName = Console.ReadLine();
            Console.Write("Indtast efternavn på deltager: ");
            string lastName = Console.ReadLine();
            Console.Write("Indtast gadenavn: ");
            string streetName = Console.ReadLine();
            Console.Write("Indtast gadenummer: ");
            string streetNumber = Console.ReadLine();
            Console.Write("Indtast by: ");
            string city = Console.ReadLine();
            Console.Write("Indtast postnummer: ");
            string zipCode = Console.ReadLine();
            Console.Write("Indtast telefonnummer: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Indtast email: ");
            string email = Console.ReadLine();
            Console.Write("Indtast type rum: ");
            string roomType = Console.ReadLine();
            Console.Write("Indtast lufthavn: ");
            string airport = Console.ReadLine();
           
         
            
            control.CreateTripCustomer(firstName, lastName, streetName,
                                       streetNumber, city, zipCode, phoneNumber, 
                                       email, roomType, airport, Id);

            Console.WriteLine("Tryk 'Enter' for at komme tilbage til menuen");
            Console.Read();
        }



        public void UpdateTripCustomer ()
        {
            Console.WriteLine("Vælg rejse fra listen over rejser.");
            Console.WriteLine();
            control.GetTrips();
            Console.WriteLine();
            Console.WriteLine("Indtast id på rejse");
            string TripId = Console.ReadLine();
            int Id = Convert.ToInt32(TripId);
            Console.Clear();
            control.ShowTripCustomers(Id);
            Console.WriteLine();
            Console.Write("Indtast id på kunde.");
            string CustomerID = Console.ReadLine();
            int CustomerPassID = Convert.ToInt32(CustomerID);
            
            bool running = true;
            while(running)
            {
                
                Console.WriteLine("1. indtast Pas informationer");
                Console.WriteLine("2. opret ledsager");
                Console.Write("Dit valg: ");
                string input2 = Console.ReadLine();

                switch (input2)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("--- Opdater Pas Informationer ---");
                        Console.Write("Indsæt passnummer: ");
                        string passportNumber = Console.ReadLine();

                        Console.Write("Indsæt udstedsdato: ");
                        string dateOfIssue = Console.ReadLine();

                        Console.Write("Indsæt udløbsdato: ");
                        string expireDate = Console.ReadLine();

                        Console.Write("Indsæt fødseldagsdato (--/--/--/): ");
                        string dateOfBirth = Console.ReadLine();
                        //control.CreatePassport(passportNumber, dateOfIssue, expireDate, dateOfBirth, CustomerPassId);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("--- Opdater ledsager ---");
                        Console.Write("???????????");
                        // DB SP til at opdatere
                        break;

                    default:
                        break;
                }
            }
              
        }
        public void ShowTripCustomer()
        {
            Console.WriteLine("Vælg rejse fra listen over rejser.");
            Console.WriteLine();
            control.GetTrips();
            Console.WriteLine();
            Console.WriteLine("Indtast id på rejse");
            string TripId = Console.ReadLine();
            int Id = Convert.ToInt32(TripId);
            Console.Clear();
            control.ShowTripCustomers(Id);
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }
    }
}
