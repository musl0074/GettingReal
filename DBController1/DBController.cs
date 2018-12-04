using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBController
{
    public class DBController
    {
        private static string connectionString = "Server=EALSQL1.eal.local; Database= B_DB06_2018; User Id=B_STUDENT06; Password=B_OPENDB06;";
        public void InsertPet(string petName, string petType, string petBreed, string petDOBl, string petWeight, string ownerID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("spInsertPet", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@PetName", petName));
                    cmd1.Parameters.Add(new SqlParameter("@PetType", petType));
                    cmd1.Parameters.Add(new SqlParameter("@PetBreed", petBreed));
                    cmd1.Parameters.Add(new SqlParameter("@PetDOBl", petDOBl));
                    cmd1.Parameters.Add(new SqlParameter("@PetWeight", petWeight));
                    cmd1.Parameters.Add(new SqlParameter("@OwnerID", ownerID));

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
