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
                        CreateTrip();
                        break;
                    case "2":
                        Console.Clear();
                        CreateTripCustomer();                       
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
            Console.WriteLine("Kulturrejser");
            Console.WriteLine();
            Console.WriteLine("1. Opret kulturrejse");
            Console.WriteLine("2. Opret kunde til rejse");
            Console.WriteLine("0. Exit");
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
            Console.Write("Indtast navn på deltager: ");
            string name = Console.ReadLine();
            Console.Write("Indtast navn på ledsager: ");
            string plusOne = Console.ReadLine();
            Console.Write("Indtast addresse: ");
            string address = Console.ReadLine();
            Console.Write("Indtast postnummer: ");
            string zipCode = Console.ReadLine();
            Console.Write("Indtast by: ");
            string city = Console.ReadLine();
            Console.Write("Indtast telefonnummer: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Indtast email: ");
            string email = Console.ReadLine();
            Console.Write("Indtast type rum: ");
            string roomType = Console.ReadLine();
            Console.Write("Indtast lufthavn: ");
            string airport = Console.ReadLine();
            Console.Write("Indtast navn på eksisterende rejse: ");
            string tripName = Console.ReadLine();         
            
            control.CreateTripCustomer(name, plusOne, address,
                                       zipCode, city, phoneNumber, 
                                       email, roomType, airport, tripName);

            Console.WriteLine("Tryk 'Enter' for at komme tilbage til menuen");
            Console.Read();
        }
    }
}
