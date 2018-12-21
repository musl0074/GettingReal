using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public class Trip
    {
        private List<TripCustomer> tripCustomers = new List<TripCustomer>();

        public string Id { get; set; }
        public string TripName { get; set; }
        public string TripDate { get; set; }


        public Trip()
        {

        }

        public Trip (string id, string name, string date)
        {
            this.Id = id;
            this.TripName = name;
            this.TripDate = date;
        }

        public Trip (string name, string date)
        {
            TripName = name;
            TripDate = date;
        }

        
        public void CreateTripCustomers (string id, string fullName, string addressInformation, string contactInformation)
        {
            TripCustomer tripCustomer = new TripCustomer(id, fullName, addressInformation, contactInformation);
            tripCustomers.Add(tripCustomer);
        }

        public void CreateTripCustomers(string fullName, string PassportNumber, string DateOfIssue, string PassportExpireDate, string DateOfBirth)
        {
            TripCustomer tripCustomer = new TripCustomer(fullName, PassportNumber, DateOfIssue, PassportExpireDate, DateOfBirth);
            tripCustomers.Add(tripCustomer);
        }

        public void CreateTripCustomers (string fullName, string companion, string roomType, string airportName, string depositeStatus, string balanceStatus)
        {
            TripCustomer tripCustomer = new TripCustomer(fullName, companion, roomType, airportName, depositeStatus, balanceStatus);
            tripCustomers.Add(tripCustomer);
        }


        public List<TripCustomer> ShowTripCustomers ()
        {
            return tripCustomers;
        }

        public void DeleteTripCustomers()
        {
            tripCustomers.Clear();
        }
    }
}
