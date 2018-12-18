using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public interface ITripInformation
    {
        string RoomType { get; set; }
        string AirportName { get; set; }
    }
}
