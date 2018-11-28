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
                ShowMenu();
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "0":
                        running = false;
                        break;
                    case "1":
                        CreateTrip();
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
            Console.WriteLine("");
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
            Console.WriteLine("Indtast navn på rejse");
            string tripName = Console.ReadLine();
            Console.WriteLine("Indtast dato for rejsen");
            string tripDate = Console.ReadLine();
            control.CreateTrip(tripName, tripDate);
        }
    }
}
