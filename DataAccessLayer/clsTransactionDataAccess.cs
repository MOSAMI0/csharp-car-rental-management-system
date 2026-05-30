using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsTransactionDataAccess
    {
        public static int AddTransaction(int bookingID, int returnID,
            string paymentMethod, decimal paid, decimal actual)
        {
            int ID = -1;

            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"INSERT INTO RentalTransaction
                (BookingID, ReturnID, PaymentMethod, PaidAmount, ActualAmount)
                VALUES
                (@Booking,@Return,@Method,@Paid,@Actual);
                SELECT SCOPE_IDENTITY();";

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Booking", bookingID);
                cmd.Parameters.AddWithValue("@Return", returnID);
                cmd.Parameters.AddWithValue("@Method", paymentMethod);
                cmd.Parameters.AddWithValue("@Paid", paid);
                cmd.Parameters.AddWithValue("@Actual", actual);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                    ID = Convert.ToInt32(result);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            return ID;
        }


        public static DataTable GetAllTransactions()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"
                SELECT t.TransactionID,
                       t.BookingID,
                       t.ReturnID,
                       t.PaymentMethod,
                       t.PaidAmount,
                       t.ActualAmount,
                       t.RemainingAmount,
                       t.RefundAmount,
                       t.TransactionDate
                FROM RentalTransaction t";

                cmd = new SqlCommand(query, conn);

                conn.Open();
                dt.Load(cmd.ExecuteReader());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return dt;
        }

        public static bool HasTransaction(int returnID)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = "SELECT COUNT(*) FROM RentalTransaction WHERE ReturnID=@ID";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", returnID);

                conn.Open();

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}