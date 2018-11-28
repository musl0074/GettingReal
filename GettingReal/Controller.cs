using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CultureTravelLibrary;

namespace GettingReal
{
    public class Controller
    {
        private TripRepo tripRepo = new TripRepo();

        public void CreateTrip(string tripName, string tripDate)
        {
            tripRepo.CreateTrip(tripName, tripDate);
        }

        public TripRepo GetTripRepo()
        {
            return tripRepo;
        }
    }
}
