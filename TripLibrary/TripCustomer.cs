using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripLibrary
{
    public class TripCustomer : IPersonalInformation, IContactInformation, ITripInformation, IPassportInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string CityName { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string RoomType { get; set; }
        public string AirportName { get; set; }
        public string PassportNumber { get; set; }
        public string ExpireDate { get; set; }
        public string DateOfIssue { get; set; }
        public string DateOfBirth { get; set; }
        public string Id { get; set; }

        // Properties to read from Database
        public string FullName { get; set; }
        public string AddressInformation { get; set; }
        public string ContactInformation { get; set; }
        public string Companion { get; set; }
        public string DepositeStatus { get; set; }
        public string BlanceStatus { get; set; }


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

        public TripCustomer(string fullName, string companion, string roomtype, string airportName, string depositStatus, string balanceStatus)
        {
            this.FullName = fullName;
            this.Companion = companion;
            this.RoomType = roomtype;
            this.AirportName = airportName;
            this.DepositeStatus = depositStatus;
            this.BlanceStatus = balanceStatus;
        }
    }

}
