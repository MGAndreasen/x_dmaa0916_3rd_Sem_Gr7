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
            string Query = "SELECT s.Zipcode, s.Name FROM dbo.Booking_City AS s WHERE s.Zipcode = @ID";

            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.Add("@ID", SqlDbType.SmallInt);
                cmd.Parameters["@ID"].Value = 9999;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //reader.NextResult();
                if (reader.HasRows)
                {

                    return new City
                    (
                        reader.GetInt32(0),
                        reader.GetString(1)
                    );
                }

                return null;
            }
        }

        public void Create(City obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_City (@Zipcode, @Name)", con);
                    cmd.Parameters.AddWithValue("@Zipcode", obj.Zipcode);
                    cmd.Parameters.AddWithValue("@Name", obj.CityName);
                    con.Open();
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
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_City SET Zipcode=@zipcode, Name=@name WHERE Zipcode=@zipcode", con);

                    cmd.Parameters.AddWithValue("name", obj.CityName);
                    cmd.Parameters.AddWithValue("zipcode", obj.Zipcode);
                    //cmd.Parameters.AddWithValue("id", obj.Id);  VI SKAL TILFØJE ID I DATABASEN OG I MODEL
                    // Nej vi skal bare benytte Zipcode som ID da denne er uniq

                    cmd.ExecuteNonQuery();
                }
                scope.Complete();
            }

        }
    }
}




