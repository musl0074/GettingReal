using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public interface IPersonalInformation
    {
        string FirstName { get; set; }
        string LastName { get; set; }


        string StreetName { get; set; }
        string StreetNumber { get; set; }
        string CityName { get; set; }
        string ZipCode { get; set; }

    }
}
