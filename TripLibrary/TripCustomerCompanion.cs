using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public class TripCustomerCompanion : IPersonalInformation, IPassportInformation
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string StreetName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string StreetNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CityName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ZipCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string PassportNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DateOfIssue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DateOfBirth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
