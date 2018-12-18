using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TripLibrary;

namespace GettingReal
{
    
    class DBController
    {
        private TripRepository tripRepo = new TripRepository();
        private static string connectionString = "Server=EALSQL1.eal.local; Database= B_DB06_2018; User Id=B_STUDENT06; Password=B_OPENDB06;";
        public void InsertTrip(string tripName, string date)
        {

            Trip newTrip = new Trip(tripName, date);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("spInsertTrip", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@TripName", newTrip.Name));
                    cmd1.Parameters.Add(new SqlParameter("@TripDate", newTrip.Date));

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


        public void SpPrintList(int tripID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("PrintTripCustomers", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@TripID", tripID));

                    SqlDataReader reader = cmd1.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string TripCustomer = reader["CustomerName"].ToString();
                            string Companion = reader["CompanionName"].ToString();
                            string Airport = reader["AirportName"].ToString();
                            string Room = reader["RoomType"].ToString();
                            string deposit = reader["DepositeStatus"].ToString();
                            string Balance = reader["BalanceStatus"].ToString();

                            Console.WriteLine(TripCustomer + ". " + Companion + ". " + Airport + ". " + Room + ". " + deposit + ". " + Balance + ". ");

                        }


                    }

                }

                catch (SqlException e)
                {
                    Console.WriteLine("Ups" + e.Message);
                }
            }
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
                            tripRepo.CreateTrip(Id, Name, Date);
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

        public void ShowTrip(int tripID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("ShowTripInfo", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@TripID", tripID));

                    SqlDataReader reader = cmd1.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string TripName = reader["TripName"].ToString();
                            string TripDate = reader["TripDate"].ToString();


                            tripRepo.CreateTrip(TripName, TripDate);
                        }


                    }

                }

                catch (SqlException e)
                {
                    Console.WriteLine("Ups" + e.Message);
                }
            }
        }

    }
}
