using CultureTravelLibrary;
using System;
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
            Console.WriteLine("Kulturrejser");
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
                Console.WriteLine("1. Opret Rejse");
                string input = GetUserChoice();

                switch (input)
                {
                    case "1":
                        CreateTrip();
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
                Console.WriteLine("1. Opret Kunde");
                Console.WriteLine("2. Opdater Kunde");
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
            Console.Write("Indtast fornavn på deltager: ");
            string firstName = Console.ReadLine();
            Console.Write("Indtast efternavn på deltager: ");
            string lastName = Console.ReadLine();
            Console.Write("Indtast navn på ledsager: ");
            string plusOne = Console.ReadLine();
            Console.Write("Indtast gadenavn: ");
            string streetName = Console.ReadLine();
            Console.Write("Indtast gadenummer: ");
            string streetNumber = Console.ReadLine();
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
            
            control.CreateTripCustomer(firstName, lastName, plusOne, streetName,
                                       streetNumber, zipCode, city, phoneNumber, 
                                       email, roomType, airport, tripName);

            Console.WriteLine("Tryk 'Enter' for at komme tilbage til menuen");
            Console.Read();
        }



        public void UpdateTripCustomer ()
        {
            Console.WriteLine("Indtast navn på rejsen");
            string tripName = Console.ReadLine();
            // DB SP der reader alle tripCustomers WHERE TripName = @tripName

            // 1. Hans Børge ...........
            // 2. Daniel Drommedar

            Console.Write("Dit valg: ");
            string input = Console.ReadLine();

            TripCustomer dbTripCustomer = control.DBTripCustomer();   // Get current version in DB
            
            bool running = true;
            while(running)
            {
                Console.Clear();

                Console.WriteLine(dbTripCustomer.FirstName);
                Console.WriteLine(dbTripCustomer.LastName);
                Console.WriteLine(dbTripCustomer.StreetName);
                Console.WriteLine(dbTripCustomer.StreetNumber);
                Console.WriteLine(dbTripCustomer.ZipCode);
                Console.WriteLine(dbTripCustomer.City);
                Console.WriteLine(dbTripCustomer.PhoneNumber);
                Console.WriteLine(dbTripCustomer.Email);
                Console.WriteLine(dbTripCustomer.RoomType);
                Console.WriteLine(dbTripCustomer.Airport);
                Console.WriteLine(dbTripCustomer.PassportNumber);
                Console.WriteLine(dbTripCustomer.DateOfIssue);
                Console.WriteLine(dbTripCustomer.ExpireDate);
                Console.WriteLine(dbTripCustomer.DateOfBirth + "\n");
                
                Console.WriteLine("1. Opdater Pas informationer");
                Console.WriteLine("2. Opdater ledsager");
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


                        dbTripCustomer.PassportNumber = passportNumber;
                        dbTripCustomer.DateOfIssue = dateOfIssue;
                        dbTripCustomer.ExpireDate = expireDate;
                        dbTripCustomer.DateOfBirth = dateOfBirth;
                        // DB SP Til at opdatere pass informationer ud med disse oplysninger
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
    }
}
