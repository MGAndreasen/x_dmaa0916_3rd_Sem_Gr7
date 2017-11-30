using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Booking.Service.Helpers
{
    public class TransactionOptionHelper
    {

        public static TransactionOptions GetDefaultTransactionOption()
        {
            return new TransactionOptions
            {
                IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted
            };
        }

    }
}
