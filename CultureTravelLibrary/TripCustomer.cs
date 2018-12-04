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
        // PERSON
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // TRIP COMPANION
        public string PlusOne { get; set; }

        // ADDRESS
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        // CONTACT_INFO
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


        // ROOMTYPE
        public string RoomType { get; set; }

        // AIRPORT
        public string Airport { get; set; }

        // PASSPORT
        public string DateOfIssue { get; set; }
        public string ExpireDate { get; set; }
        public string DateOfBirth { get; set; }
        #endregion

        // Constructor -- applies parameters to the properties
        public TripCustomer (string firstName, string lastName, string plusOne, string streetName, string streetNumber, string zipCode, string city,
                             string phoneNumber, string email, string roomType, string airport)
        {
            FirstName = firstName;
            LastName = lastName;
            PlusOne = plusOne;
            StreetName = streetName;
            StreetNumber = streetNumber;
            ZipCode = zipCode;
            City = city;
            PhoneNumber = phoneNumber;
            Email = email;
            RoomType = roomType;
            Airport = airport;
        }

        

    }
}
