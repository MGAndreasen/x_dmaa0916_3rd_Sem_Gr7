using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DB
{
    public class DbSeat
    {


        public void CreateSeat(int ID, int Number, bool Available)
        {
            //Open
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText = "Insert into dbo.Seat(ID, Number, Avaliable)";
                }

                catch
                {
                    Console.WriteLine("Den gider sgu ikke lige");
                }
                //open
            }
        }
    }
}
