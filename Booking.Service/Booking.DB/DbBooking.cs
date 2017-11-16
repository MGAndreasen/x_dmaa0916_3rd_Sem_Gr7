using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models;
namespace Booking.DB
{
    public class DbBooking
    {
       private DbBooking()
        {
            
        }
       
        public void CreateBooking(Destination StartDestination, Destination EndDestination)
        {
            //Open
            using (SqlCommand cmd = new SqlCommand())
            {
                try { 
                cmd.CommandText = "Insert into dbo.Booking(StartDestination, EndDestination)";
                }

                catch
                {
                    Console.WriteLine("Noget gik sku galt med CreateBooking");
                }
                //open
            }
        }

        public void deleteBooking(//Booking  bookingId)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                try { 
                cmd.CommandText = "Delete where Id is (bookingId == bookingId) in dbo.Booking";
                }

                catch
                {
                    Console.WriteLine("Noget gik galt med DeleteBooking");
                }
            }

        }




        public void getBooking()
        {
            //
        }


    }
}
