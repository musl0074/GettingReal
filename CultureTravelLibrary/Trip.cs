using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureTravelLibrary
{
    public class Trip
    {
        public string TripName { get; set; }
        public string TripDate { get; set; }

        public Trip(string tripName, string tripDate)
        {
            TripName = tripName;
            TripDate = tripDate;
        }
        

    }
}
