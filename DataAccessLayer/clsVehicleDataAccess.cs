using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace DataAccessLayer
{
    public class clsVehicleDataAccess
    {














        public static bool GetVehicleByID(int ID,
    ref int MakeID,
    ref int ModelID,
    ref int Year,
    ref int FuelID,
    ref int CategoryID,
    ref string Plate,
    ref int Mileage,
    ref decimal Price,
    ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Vehicles WHERE VehicleID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                MakeID = reader["MakeID"] != DBNull.Value ? Convert.ToInt32(reader["MakeID"]) : 0;
                                ModelID = reader["ModelID"] != DBNull.Value ? Convert.ToInt32(reader["ModelID"]) : 0;
                                Year = reader["Year"] != DBNull.Value ? Convert.ToInt32(reader["Year"]) : 0;
                                FuelID = reader["FuelTypeID"] != DBNull.Value ? Convert.ToInt32(reader["FuelTypeID"]) : 0;
                                CategoryID = reader["CategoryID"] != DBNull.Value ? Convert.ToInt32(reader["CategoryID"]) : 0;
                                Plate = reader["PlateNumber"] != DBNull.Value ? reader["PlateNumber"].ToString() : "";
                                Mileage = reader["Mileage"] != DBNull.Value ? Convert.ToInt32(reader["Mileage"]) : 0;
                                Price = reader["RentalPricePerDay"] != DBNull.Value ? Convert.ToDecimal(reader["RentalPricePerDay"]) : 0;
                                ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : "";

                                System.Diagnostics.Debug.WriteLine($"Retrieved Vehicle ID {ID}: Make={MakeID}, Model={ModelID}, Plate={Plate}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error in GetVehicleByID: {ex.Message}");
                        isFound = false;
                    }
                }
            }

            return isFound;
        }





        public static DataTable GetAllVehicles()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT v.VehicleID,
                                    m.MakeName,
                                    mo.ModelName,
                                    v.Year,
                                    f.FuelTypeName,
                                    c.CategoryName,
                                    v.PlateNumber,
                                    v.Mileage,
                                    v.RentalPricePerDay,
                                    v.IsAvailableForRent,
                                    v.ImagePath
                             FROM Vehicles v
                             JOIN Makes m ON v.MakeID = m.MakeID
                             JOIN Models mo ON v.ModelID = mo.ModelID
                             JOIN FuelTypes f ON v.FuelTypeID = f.FuelTypeID
                             JOIN VehicleCategories c ON v.CategoryID = c.CategoryID";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                dt.Load(cmd.ExecuteReader());
            }
            finally { conn.Close(); }

            return dt;
        }

        public static int AddVehicle(int MakeID, int ModelID, int Year,
            int FuelID, int CategoryID,
            string Plate, int Mileage, decimal Price, string ImagePath)
        {
            int ID = -1;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Vehicles
                            (MakeID, ModelID, Year, FuelTypeID, CategoryID,
                             PlateNumber, Mileage, RentalPricePerDay, IsAvailableForRent, ImagePath)
                            VALUES
                            (@MakeID,@ModelID,@Year,@Fuel,@Category,
                             @Plate,@Mileage,@Price,1, @ImagePath);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@MakeID", MakeID);
            cmd.Parameters.AddWithValue("@ModelID", ModelID);
            cmd.Parameters.AddWithValue("@Year", Year);
            cmd.Parameters.AddWithValue("@Fuel", FuelID);
            cmd.Parameters.AddWithValue("@Category", CategoryID);
            cmd.Parameters.AddWithValue("@Plate", Plate);
            cmd.Parameters.AddWithValue("@Mileage", Mileage);
            cmd.Parameters.AddWithValue("@Price", Price);

            if (ImagePath != "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                    ID = Convert.ToInt32(result);
            }
            finally { conn.Close(); }

            return ID;
        }

        public static bool UpdateVehicle(int ID, int MakeID, int ModelID, int Year,
            int FuelID, int CategoryID,
            string Plate, int Mileage, decimal Price, string ImagePath)
        {
            int rows = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Vehicles SET
                            MakeID=@MakeID,
                            ModelID=@ModelID,
                            Year=@Year,
                            FuelTypeID=@Fuel,
                            CategoryID=@Category,
                            PlateNumber=@Plate,
                            Mileage=@Mileage,
                            RentalPricePerDay=@Price,
                            ImagePath = @ImagePath
                            WHERE VehicleID=@ID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@MakeID", MakeID);
            cmd.Parameters.AddWithValue("@ModelID", ModelID);
            cmd.Parameters.AddWithValue("@Year", Year);
            cmd.Parameters.AddWithValue("@Fuel", FuelID);
            cmd.Parameters.AddWithValue("@Category", CategoryID);
            cmd.Parameters.AddWithValue("@Plate", Plate);
            cmd.Parameters.AddWithValue("@Mileage", Mileage);
            cmd.Parameters.AddWithValue("@Price", Price);

            if (ImagePath != "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }
            finally { conn.Close(); }

            return rows > 0;
        }

        public static bool DeleteVehicle(int ID)
        {
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE Vehicles WHERE VehicleID=@ID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            return rows > 0;
        }


        public static DataTable GetAllMakes()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT MakeID, MakeName FROM Makes", conn);

            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            return dt;
        }








        








        public static DataTable GetModels(int makeID)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                SELECT DISTINCT f.ModelID, f.ModelName
                FROM Car_Details v
                INNER JOIN Models f ON v.ModelID = f.ModelID
                WHERE v.MakeID = @MakeID;";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@MakeID", makeID);

            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            return dt;
        }







        public static bool SetVehicleAvailability(int vehicleID, bool isAvailable)
        {
            int rows = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Vehicles
                     SET IsAvailableForRent = @IsAvailable
                     WHERE VehicleID = @ID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ID", vehicleID);
            cmd.Parameters.AddWithValue("@IsAvailable", isAvailable);

            conn.Open();
            rows = cmd.ExecuteNonQuery();
            conn.Close();

            return rows > 0;
        }

        public static DataTable GetAvailableVehicles()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            
            conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"
                 SELECT v.VehicleID,
               (m.MakeName + ' ' + mo.ModelName + ' ' 
               + CAST(v.Year AS NVARCHAR) 
               + ' (' + v.PlateNumber + ')') AS VehicleName
            FROM Vehicles v
            JOIN Makes m ON v.MakeID = m.MakeID
            JOIN Models mo ON v.ModelID = mo.ModelID
            WHERE v.IsAvailableForRent = 1";

            cmd = new SqlCommand(query, conn);

            try
            {
                

                conn.Open();

                reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return dt;
        }

        public static decimal GetVehiclePrice(int vehicleID)
        {
            decimal price = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT RentalPricePerDay FROM Vehicles WHERE VehicleID=@ID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", vehicleID);

            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();

            if (result != null)
                price = Convert.ToDecimal(result);

            return price;
        }


        public static int GetVehicleMileage(int vehicleID)
        {
            int Mileage = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Mileage FROM Vehicles WHERE VehicleID=@ID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", vehicleID);

            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();

            if (result != null)
                Mileage = Convert.ToInt16(result);

            return Mileage;
        }

        public static DataTable GetVehicleDetails(int vehicleID)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"
        SELECT v.VehicleID,
               m.MakeName,
               mo.ModelName,
               v.Year,
               f.FuelTypeName,
               c.CategoryName,
               v.PlateNumber,
               v.Mileage,
               v.RentalPricePerDay,
               v.IsAvailableForRent,
               v.ImagePath
        FROM Vehicles v
        JOIN Makes m ON v.MakeID = m.MakeID
        JOIN Models mo ON v.ModelID = mo.ModelID
        JOIN FuelTypes f ON v.FuelTypeID = f.FuelTypeID
        JOIN VehicleCategories c ON v.CategoryID = c.CategoryID
        WHERE v.VehicleID = @ID";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", vehicleID);

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


        public static DataTable GetCategoriesByModel(int modelID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT DISTINCT C.CategoryID, C.CategoryName
                         FROM Car_Details V
                         INNER JOIN VehicleCategories C ON V.CategoryID = C.CategoryID
                         WHERE V.ModelID = @ModelID
                         ORDER BY C.CategoryName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ModelID", modelID);
                    conn.Open();
                    dt.Load(cmd.ExecuteReader());
                }
            }

            return dt;
        }
        public static DataTable GetYearsByModelAndCategory(int modelID, int categoryID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT DISTINCT Year
                         FROM Car_Details
                         WHERE ModelID = @ModelID
                         AND CategoryID = @CategoryID
                         AND Year IS NOT NULL
                         ORDER BY Year DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ModelID", modelID);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                    conn.Open();
                    dt.Load(cmd.ExecuteReader());
                }
            }

            return dt;
        }

        public static DataTable GetFuelTypesByModelAndCategory(int modelID, int categoryID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT DISTINCT f.FuelTypeID, f.FuelTypeName
                         FROM Car_Details cd
                         INNER JOIN FuelTypes f ON cd.FuelTypeID = f.FuelTypeID
                         WHERE cd.ModelID = @ModelID AND cd.CategoryID = @CategoryID
                         ORDER BY f.FuelTypeName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ModelID", modelID);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                    conn.Open();
                    dt.Load(cmd.ExecuteReader());
                }
            }

            return dt;
        }

        public static DataTable GetYearsByModelCategoryAndFuel(int modelID, int categoryID, int fuelID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT DISTINCT Year
                         FROM Car_Details
                         WHERE ModelID = @ModelID 
                         AND CategoryID = @CategoryID
                         AND FuelTypeID = @FuelID
                         ORDER BY Year DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ModelID", modelID);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    cmd.Parameters.AddWithValue("@FuelID", fuelID);

                    conn.Open();
                    dt.Load(cmd.ExecuteReader());
                }
            }

            return dt;
        }



        public static bool UpdateMileage(int vehicleID, int mileage)
        {
            int rowsAffected = 0;

            using (SqlConnection conn =
                new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE Vehicles
                         SET Mileage = @Mileage
                         WHERE VehicleID = @VehicleID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Mileage", mileage);
                    cmd.Parameters.AddWithValue("@VehicleID", vehicleID);

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected > 0;
        }


    }
}