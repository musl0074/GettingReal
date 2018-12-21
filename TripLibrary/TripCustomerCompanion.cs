using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public class TripCustomerCompanion : IPersonalInformation, IPassportInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string CityName { get; set;}
        public string ZipCode { get; set; }

        public string PassportNumber { get; set; }
        public string ExpireDate { get; set; }
        public string DateOfIssue { get; set; }
        public string DateOfBirth { get; set; }
        
    }

    
}
