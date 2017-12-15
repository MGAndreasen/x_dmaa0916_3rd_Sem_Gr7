using Booking.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Booking.DB.ScopeHelper;

namespace Booking.DB
{
    public class DbCity : IDbCRUD<City>
    {

        private DataAccess data = DataAccess.Instance;


        public void Delete(int id)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Booking_City WHERE ZipCode=@id", con); //VI SKAL TILFØJE ID TIL CITY I DATABASEN
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }

        public City Get(int id)
        {
            string Query = "SELECT ZipCode, Name FROM dbo.Booking_City WHERE ZipCode = @ID";

            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = Query;
                cmd.Parameters.AddWithValue("ID", id);
                
                con.Open();
               
                SqlDataReader reader = cmd.ExecuteReader();
  
                if (reader.HasRows)
                {
                    reader.Read();

                    return new City((int)reader["ZipCode"], (string)reader["Name"]);
                        
                }

                return null;
            }
        }

        public void Create(City obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO dbo.Booking_City (ZipCode, Name) VALUES (@ZipCode, @Name)";
                    cmd.Parameters.Add("@ZipCode", SqlDbType.Int).Value = obj.Zipcode;
                    cmd.Parameters.AddWithValue("Name", SqlDbType.NVarChar).Value = obj.CityName;

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }

        public void Update(City obj)
        {
            TransactionOptions isoLevel = ScopeHelper.ScopeHelper.GetDefault();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_City SET ZipCode=@zipcode, Name=@name WHERE Zipcode=@zipcode", con);

                    cmd.Parameters.AddWithValue("@name", obj.CityName);
                    cmd.Parameters.AddWithValue("@zipcode", obj.Zipcode);

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }

        public IEnumerable<City> GetAll()
        {
            List<City> citys = new List<City>();

            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM dbo.Booking_City";
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        citys.Add(new City
                        {
                            Zipcode = (int)rdr["ZipCode"],
                            CityName = (string)rdr["Name"]                            
                        });
                    }
                }
            }
            return citys;
        }
    }
}




