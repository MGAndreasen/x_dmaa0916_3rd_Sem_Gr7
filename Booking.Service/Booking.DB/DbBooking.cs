using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using Booking.Models;
using System.Transactions;


namespace Booking.DB
{
    public class DbBooking : IDbCRUD<Bookings>
    {
        private DataAccess data = DataAccess.Instance;

        public void Delete(int id)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Booking_Booking WHERE Id=@id", con);

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                    scope.Complete();
                }
            }

        }

        public Bookings Get(int id)
        {
            DbPayment dbp = new DbPayment();
            DbCustomer dbc = new DbCustomer();
            DbDestination dbd = new DbDestination();
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Booking_Booking WHERE Id=@Id", con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                return new Bookings
                {
                    Id = (int)rdr["Id"],
                    Payment = dbp.Get((int)rdr["Payment_Id"]),
                    Customer = dbc.Get((int)rdr["Customer_Id"]),
                    StartDestination = dbd.Get((int)rdr["StartDestination"]),
                    EndDestination = dbd.Get((int)rdr["EndDestination"]),
                    Date = (DateTime)rdr["Date"],
                    TotalPrice = (int)rdr["Price"]
                };
            }

        }

        public void Create(Bookings obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Booking (Id, Payment_Id, Customer_Id, StartDestination, EndDestination, Date, Price) VALUES (@id, @Payment, @Customer, @StartDestination, @EndDestination, @Date, @Price)", con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Payment", SqlDbType.Int).Value = obj.Id; // <-------------------------
                    cmd.Parameters.Add("@Customer", SqlDbType.Int).Value = obj.Id; // <-------------------------
                    cmd.Parameters.Add("@StartDestination", SqlDbType.Int).Value = obj.StartDestination; // <-------------------------
                    cmd.Parameters.Add("@EndDestination", SqlDbType.Int).Value = obj.EndDestination; // <-------------------------
                    cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.Date;
                    cmd.Parameters.Add("@Price", SqlDbType.Int).Value = obj.TotalPrice;

                    cmd.ExecuteNonQuery();

                    scope.Complete();
                }
            }
        }

        public void Update(Bookings obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Booking_Booking SET Id=@Id, Payment_Id=@PI, Customer_Id=@CI, StartDestination=@SD, EndDestination=@ED, Date=@Date, Price=@Price", con);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@PI", SqlDbType.Int).Value = obj.Payment; // <-------------------------
                    cmd.Parameters.Add("@CI", SqlDbType.Int).Value = obj.Customer; // <-------------------------
                    cmd.Parameters.Add("@SD", SqlDbType.Int).Value = obj.StartDestination; // <-------------------------
                    cmd.Parameters.Add("@ED", SqlDbType.Int).Value = obj.EndDestination; // <-------------------------
                    cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.Date;
                    cmd.Parameters.Add("@Price", SqlDbType.Int).Value = obj.Date;

                    cmd.ExecuteNonQuery();
                    scope.Complete();
                }
            }
        }
    }
}
