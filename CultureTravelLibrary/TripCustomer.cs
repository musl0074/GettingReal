using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureTravelLibrary
{
    public class TripCustomer
    {
        // Properties
        public string Name { get { return Name; } set { } }
        public string PlusOne { get { return PlusOne; } set { } }
        public string Address { get { return Address; } set { } }
        public string ZipCode { get { return ZipCode; } set { } }
        public string City { get { return City; } set { } }
        public string PhoneNumber { get { return PhoneNumber; } set { } }
        public string Email { get { return Email; } set { } }
        public string RoomType { get { return RoomType; } set { } }
        public string Airport { get { return Airport; } set { } }


        // Constructor -- applies parameters to the properties
        public TripCustomer (string name, string plusOne, string address, string zipCode, string city,
                             string phoneNumber, string email, string roomType, string airport)
        {
            Name = name;
            PlusOne = plusOne;
            Address = address;
            ZipCode = zipCode;
            City = city;
            PhoneNumber = phoneNumber;
            Email = email;
            RoomType = roomType;
            Airport = airport;
        }

    }
}
