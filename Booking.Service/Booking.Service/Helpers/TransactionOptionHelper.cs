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
