using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public class Trip
    {
        List<TripCustomer> tripCustomers = new List<TripCustomer>();

        public string Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }


        public Trip()
        {

        }

        public Trip (string id, string name, string date)
        {
            this.Id = id;
            this.Name = name;
            this.Date = date;
        }

        public Trip (string name, string date)
        {
            Name = name;
            Date = date;
        }

        
        public void CreateTripCustomers (string id, string fullName, string addressInformation, string contactInformation)
        {
            TripCustomer tripCustomer = new TripCustomer(id, fullName, addressInformation, contactInformation);
            tripCustomers.Add(tripCustomer);


        }


        public List<TripCustomer> ShowTripCustomers ()
        {
            return tripCustomers;
        }
    }
}
