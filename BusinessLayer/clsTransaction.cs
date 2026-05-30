using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public class clsTransaction
    {
        public int BookingID { get; set; }
        public int ReturnID { get; set; }

        public string PaymentMethod { get; set; }

        public decimal PaidAmount { get; set; }
        public decimal ActualAmount { get; set; }

        public decimal Remaining =>
            ActualAmount > PaidAmount ? ActualAmount - PaidAmount : 0;

        public decimal Refund =>
            PaidAmount > ActualAmount ? PaidAmount - ActualAmount : 0;

        public bool Save()
        {
            int id = clsTransactionDataAccess.AddTransaction(
                BookingID,
                ReturnID,
                PaymentMethod,
                PaidAmount,
                ActualAmount);

            return id != -1;
        }

        public static DataTable ListTransactions()
        {
            return clsTransactionDataAccess.GetAllTransactions();
        }

        public static bool HasTransaction(int returnID)
        {
            return clsTransactionDataAccess.HasTransaction(returnID);
        }
    }
}