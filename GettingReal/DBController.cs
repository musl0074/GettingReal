using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CultureTravelLibrary;

namespace GettingReal
{
    class DBController
    {
        private static string connectionString = "Server=EALSQL1.eal.local; Database= B_DB06_2018; User Id=B_STUDENT06; Password=B_OPENDB06;";
        public void InsertTrip(string tripName, string date)
        {
            DateTime dateTime = DateTime.Parse(date);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("spInsertTrip", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@TripName", tripName));
                    cmd1.Parameters.Add(new SqlParameter("@TripDate", dateTime));

                    cmd1.ExecuteNonQuery();



                }
                catch (SqlException e)
                {
                    Console.WriteLine("Ups" + e.Message);
                }
            }
        }

        public void InsertTripCustomer(string firstName, string lastName, string streetName, string streetNumber, string cityName, string zipCode
                                        , string phoneNumber, string email, string roomType, string airportName, string tripName, string tripDate)
        {
            DateTime dateTime = DateTime.Parse(tripDate);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("spInsertTrip_Customer", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@FirstName", firstName));
                    cmd1.Parameters.Add(new SqlParameter("@LastName", lastName));
                    cmd1.Parameters.Add(new SqlParameter("@StreetName", streetName));
                    cmd1.Parameters.Add(new SqlParameter("@StreetNumber", streetNumber));
                    cmd1.Parameters.Add(new SqlParameter("@CityName", cityName));
                    cmd1.Parameters.Add(new SqlParameter("@ZipCode", zipCode));
                    cmd1.Parameters.Add(new SqlParameter("@PhoneNumber", phoneNumber));
                    cmd1.Parameters.Add(new SqlParameter("@Email", email));
                    cmd1.Parameters.Add(new SqlParameter("@RoomType", roomType));
                    cmd1.Parameters.Add(new SqlParameter("@AirportName", airportName));
                    cmd1.Parameters.Add(new SqlParameter("@TripName", tripName));
                    cmd1.Parameters.Add(new SqlParameter("@TripDate", dateTime));

                    cmd1.ExecuteNonQuery();



                }
                catch (SqlException e)
                {
                    Console.WriteLine("Ups" + e.Message);
                }
            }
        }





        public void ShowTripCustomers ()
        {
            // Implementer her
        }

        public TripCustomer DBTripCustomer ()
        {
            // Implementer her


            // Opret og retuner kunde
            TripCustomer updatedCustomer = new TripCustomer("", "", "", "", "", "", "", "", "", "");
            return updatedCustomer;
        }
    }
}
