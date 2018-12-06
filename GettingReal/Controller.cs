using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void GetTrips()
        {
            dbControl.ShowTrips();
        }


        public void ShowTripCustomers (int id)
        {
            dbControl.ShowTripCustomers(id);
        }

        public void CreatePassport(string passportNumber, string dateOfIssue, string expireDate, string dateOfBirth, int CustomerPassId)
        {
            //dbControl.CreatePassport(passportNumber, dateOfIssue, expireDate, dateOfBirth, CustomerPassId)
        }



    }
}
