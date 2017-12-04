using System.Transactions;

namespace Booking.DB.ScopeHelper
{
    class ScopeHelper
    {

        public static TransactionOptions GetDefault()
        {
            TransactionOptions isoLevel = new TransactionOptions();
            isoLevel.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            return isoLevel;
        }
    }
}
