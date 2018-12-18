using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public class Trip
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }

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
        
        List<TripCustomer> customers = new List<TripCustomer>();

        public void CreateCustomers(string id, string name, string adress, string contactInfo)
        {
            TripCustomer cust = new TripCustomer(id, name, adress, contactInfo);
            customers.Add(cust);
        }
    }
}
