using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsMaintenanceDataAccess
    {

        public static int AddMaintenance(int vehicleID, string desc, decimal cost)
        {
            int id = -1;

            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"INSERT INTO VehicleMaintenance
                (VehicleID, Description, Cost, IsCompleted)
                VALUES
                (@Vehicle,@Desc,@Cost,0);
                SELECT SCOPE_IDENTITY();";

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Vehicle", vehicleID);
                cmd.Parameters.AddWithValue("@Desc", desc);
                cmd.Parameters.AddWithValue("@Cost", cost);

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                    id = Convert.ToInt32(result);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return id;
        }

        public static DataTable ListMaintenance()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"
                SELECT m.MaintenanceID,
                       v.PlateNumber,
                       m.Description,
                       m.Cost,
                       m.IsCompleted,
                       m.MaintenanceDate
                FROM VehicleMaintenance m
                JOIN Vehicles v ON m.VehicleID = v.VehicleID
                ORDER BY m.MaintenanceID DESC";

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


        public static bool CompleteMaintenance(int maintenanceID)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
                conn.Open();

                //  MOVE TO HISTORY
                string insertQuery = @"
                INSERT INTO VehicleMaintenanceHistory
                (MaintenanceID, VehicleID, Description, Cost, MaintenanceDate)
                SELECT MaintenanceID, VehicleID, Description, Cost, MaintenanceDate
                FROM VehicleMaintenance
                WHERE MaintenanceID = @ID";

                cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@ID", maintenanceID);
                cmd.ExecuteNonQuery();

                //  DELETE
                string deleteQuery = "DELETE FROM VehicleMaintenance WHERE MaintenanceID = @ID";

                cmd = new SqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@ID", maintenanceID);
                cmd.ExecuteNonQuery();

                return true;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        public static int GetVehicleID(int maintenanceID)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = "SELECT VehicleID FROM VehicleMaintenance WHERE MaintenanceID=@ID";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", maintenanceID);

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                    return Convert.ToInt32(result);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return -1;
        }


        //public static bool UpdateStatus(int maintenanceID, bool isCompleted)
        //{
        //    SqlConnection conn = null;
        //    SqlCommand cmd = null;

        //    try
        //    {
        //        conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //        string query = @"UPDATE VehicleMaintenance
        //                 SET IsCompleted = @Status
        //                 WHERE MaintenanceID = @ID";

        //        cmd = new SqlCommand(query, conn);

        //        cmd.Parameters.AddWithValue("@ID", maintenanceID);
        //        cmd.Parameters.AddWithValue("@Status", isCompleted);

        //        conn.Open();

        //        return cmd.ExecuteNonQuery() > 0;
        //    }
        //    finally
        //    {
        //        if (conn != null && conn.State == System.Data.ConnectionState.Open)
        //            conn.Close();
        //    }
        //}

        

        //public static bool HasPendingMaintenance(int vehicleID)
        //{
        //    SqlConnection conn = null;
        //    SqlCommand cmd = null;

        //    try
        //    {
        //        conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //        string query = @"SELECT COUNT(*) 
        //                 FROM VehicleMaintenance
        //                 WHERE VehicleID = @ID
        //                 AND (IsCompleted = 0 OR IsCompleted IS NULL)";

        //        cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@ID", vehicleID);

        //        conn.Open();

        //        int count = (int)cmd.ExecuteScalar();

        //        return count > 0;
        //    }
        //    finally
        //    {
        //        if (conn != null && conn.State == System.Data.ConnectionState.Open)
        //            conn.Close();
        //    }
        //}





        //for history 

        public static DataTable ListMaintenanceHistory()
        {
            DataTable dt = new DataTable();

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select  * from VehicleMaintenanceHistory";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch { }
            finally { connection.Close(); }

            return dt;
        }


    }
}
