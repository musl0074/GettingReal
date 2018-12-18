using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public class TripCustomer : IPersonalInformation, IContactInformation, ITripInformation, IPassportInformation
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string StreetName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string StreetNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CityName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ZipCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RoomType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AirportName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PassportNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DateOfIssue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DateOfBirth { get; set; }
        public string Id { get; set; }

        // Properties to read from Database
        public string FullName { get; set; }
        public string AddressInformation { get; set; }
        public string ContactInformation { get; set; }


        public TripCustomer(string firstName, string lastName, string streetName, string streetNumber, string cityName,
                            string zipCode, string phoneNumber, string email, string roomType, string airportName)
        {
            FirstName = firstName;
            LastName = lastName;
            StreetName = streetName;
            StreetNumber = streetNumber;
            CityName = cityName;
            ZipCode = zipCode;
            PhoneNumber = phoneNumber;
            Email = email;
            RoomType = roomType;
            AirportName = airportName;
        }

        public TripCustomer(string id, string fullName, string addressInformation, string contactInformation)
        {
            Id = id;
            FullName = fullName;
            AddressInformation = addressInformation;
            ContactInformation = contactInformation;
        }

    }

}
