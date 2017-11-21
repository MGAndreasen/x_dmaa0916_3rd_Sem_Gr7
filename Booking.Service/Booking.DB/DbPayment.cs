﻿using Booking.Models;
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
    public class DbPayment : IDbCRUD<Payment>
    {
        private DataAccess data = DataAccess.Instance;

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Payment Get(int id)
        {
            using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                try
                {
                    SqlDataReader rdr = null;
                    SqlCommand cmd = new SqlCommand("SELECT FROM dbo.Booking_Payment WHERE Id = @id", con);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        return new Payment
                        {
                            Id = rdr.GetInt32(0),
                            Amount = rdr.GetInt32(1),
                            Date = rdr.GetDateTime(2)
                        };
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
        }

        public void Create(Payment obj)
        {
            TransactionOptions isoLevel = new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted };//her kan i sætte isolation om nødvendigt
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, isoLevel))
            {
                using (SqlConnection con = new SqlConnection(data.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Booking_Payment (@id, @Amount, @Date", con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = obj.Amount;
                    cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = obj.Date;
                    cmd.ExecuteNonQuery();
                    {
                        //tilføj til model.
                    }
                }
            }
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
