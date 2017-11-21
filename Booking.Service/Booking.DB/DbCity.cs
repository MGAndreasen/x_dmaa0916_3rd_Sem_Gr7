using Booking.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Booking.DB
{
    public class DbCity : IDbCRUD<City>
    {

        private DataAccess data = DataAccess.Instance;


        public void Delete(int id)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Booking_City WHERE Id=@id", con); //VI SKAL TILFØJE ID TIL CITY I DATABASEN
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }

        public City Get(int id)
        {
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT s.Zipcode, s.Name FROM dbo.Booking_City AS s WHERE Id = @id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataReader reader = cmd.ExecuteReader();
                return new City
                {
                    Zipcode = reader.GetInt32(0),
                    CityName = reader.GetString(1),
                };
            }
        }

        public void Create(City obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_City (@Zipcode, @Name)", con);
                    cmd.Parameters.Add("@Zipcode", SqlDbType.SmallInt).Value = obj.Zipcode;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = obj.CityName;

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }
        }

        public void Update(City obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_City SET Zipcode=@zipcode, Name=@name WHERE Id=@id", con);

                    cmd.Parameters.AddWithValue("name", obj.CityName);
                    cmd.Parameters.AddWithValue("zipcode", obj.Zipcode);
                    //cmd.Parameters.AddWithValue("id", obj.Id);  VI SKAL TILFØJE ID I DATABASEN OG I MODEL

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }

        }
    }
}




