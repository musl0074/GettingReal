using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GettingReal
{
    class DBController
    {
        private static string connectionString = "Server=EALSQL1.eal.local; Database= B_DB06_2018; User Id=B_STUDENT06; Password=B_OPENDB06;";
        public void InsertTrip(string tripName, string date)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("spInsertTrip", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@TripName", tripName));
                    cmd1.Parameters.Add(new SqlParameter("@TripDate", date));

                    cmd1.ExecuteNonQuery();



                }
                catch (SqlException e)
                {
                    Console.WriteLine("Ups" + e.Message);
                }
            }
        }

        public void InsertTripCustomer(string firstName, string lastName, string streetName, string streetNumber, string cityName, string zipCode
                                        , string phoneNumber, string email, string roomType, string airportName, int Id)
        {
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
                    cmd1.Parameters.Add(new SqlParameter("@TripID", Id));
                    
                    cmd1.ExecuteNonQuery();



                }
                catch (SqlException e)
                {
                    Console.WriteLine("Ups" + e.Message);
                }
            }
        }


        public void SpPrintList (int tripID)
        {
            // Implementer her..... samme som ShowTripCustomers, bare med alt det relevante data
        }


        public void ShowTripCustomers (int Id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("ShowTripCustomers", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@TripID", Id));

                    SqlDataReader reader = cmd1.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string customerId = reader["TripCustomerID"].ToString();
                            string name = reader["CustomerName"].ToString();
                            string adress = reader["CustomerAdress"].ToString();
                            string contactInfo = reader["CustomerContactInfo"].ToString();
                            
                            Console.WriteLine(customerId + ". " + name + ". " + adress + ". " + contactInfo + ".");
                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Ups" + e.Message);
                }
            }
        }

        public void ShowTrips()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("ShowTrips", con);
                    cmd1.CommandType = CommandType.StoredProcedure;


                    SqlDataReader reader = cmd1.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string Id = reader["TripID"].ToString();
                            string Name = reader["TripName"].ToString();
                            string Date = reader["TripDate"].ToString();
                            Console.WriteLine(Id + " " + Name + " " + Date + ".");
                        }
                    }
                    reader.Close();
                   
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Ups" + e.Message);
                }
            }
        }

        public void InsertTripCustomerPassport(string firstName, string lastName, string passportNumber, string dateOfIssue, string expireDate, string dateOfBirth, int customerPassID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("spInsertTrip_Passport", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@PassportNumber", passportNumber));
                    cmd1.Parameters.Add(new SqlParameter("@FirstName", firstName));
                    cmd1.Parameters.Add(new SqlParameter("@LastName", lastName));
                    cmd1.Parameters.Add(new SqlParameter("@DateOfIssue", dateOfIssue));
                    cmd1.Parameters.Add(new SqlParameter("@PassportExpireDate", expireDate));
                    cmd1.Parameters.Add(new SqlParameter("@DateOfBirth", dateOfBirth));
                    cmd1.Parameters.Add(new SqlParameter("@TripCustomerID", customerPassID));

                    cmd1.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Ups" + e.Message);
                }
            }
        }

        public void InsertTripCompanion(string firstName, string lastName,  int customerReferenceID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("spInsertTrip_Companion", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@FirstName", firstName));
                    cmd1.Parameters.Add(new SqlParameter("@LastName", lastName));
                    cmd1.Parameters.Add(new SqlParameter("@TripCustomerID", customerReferenceID));

                    cmd1.ExecuteNonQuery();

                }
                catch (SqlException e)
                {
                    Console.WriteLine("Ups" + e.Message);
                }
            }
        }

    }
}
