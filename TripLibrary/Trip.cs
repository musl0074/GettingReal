using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public class Trip
    {
        public string Name { get; set; }
        public string Date { get; set; }


        public Trip (string name, string date)
        {
            Name = name;
            Date = date;
        }
    }
}
