using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureTravelLibrary
{
    public class TripCustomer
    {
        #region Properties
        public string Name { get; set; }
        public string PlusOne { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string RoomType { get; set; }
        public string Airport { get; set; }
        #endregion

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
