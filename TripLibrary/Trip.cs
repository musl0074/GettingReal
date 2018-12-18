using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }

        public Trip (int id, string name, string date)
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
    }
}
