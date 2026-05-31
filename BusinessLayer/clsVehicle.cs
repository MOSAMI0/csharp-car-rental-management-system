using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsVehicle
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int VehicleID { get; set; }
        public int MakeID { get; set; }
        public int ModelID { get; set; }
        public int Year { get; set; }
        public int FuelID { get; set; }
        public int CategoryID { get; set; }

        public string Plate { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }

        public string ImagePath { get; set; }

        public clsVehicle()
        {
            VehicleID = -1;
            MakeID = 0;
            ModelID = 0;
            Year = 0;
            FuelID = 0;
            CategoryID = 0;
            Plate = "";
            Mileage = 0;
            Price = 0;
            ImagePath = "";
            Mode = enMode.AddNew;
        }

        private clsVehicle(int vehicleID, int makeID, int modelID, int year,
                          int fuelID, int categoryID, string plate,
                          int mileage, decimal price, string imagePath)
        {
            VehicleID = vehicleID;
            MakeID = makeID;
            ModelID = modelID;
            Year = year;
            FuelID = fuelID;
            CategoryID = categoryID;
            Plate = plate;
            Mileage = mileage;
            Price = price;
            ImagePath = imagePath;
            Mode = enMode.Update;
        }

        public static clsVehicle Find(int ID)
        {
            int makeID = 0, modelID = 0, year = 0, fuelID = 0, categoryID = 0;
            string plate = "", imagePath = "";
            int mileage = 0;
            decimal price = 0;

            if (clsVehicleDataAccess.GetVehicleByID(ID, ref makeID, ref modelID, ref year,
                ref fuelID, ref categoryID, ref plate, ref mileage, ref price, ref imagePath))
            {
                return new clsVehicle(ID, makeID, modelID, year, fuelID, categoryID,
                                     plate, mileage, price, imagePath);
            }

            return null;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicle())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateVehicle();
                default:
                    return false;
            }
        }

        private bool _AddNewVehicle()
        {
            VehicleID = clsVehicleDataAccess.AddVehicle(
                MakeID, ModelID, Year, FuelID, CategoryID,
                Plate, Mileage, Price, ImagePath);
            return VehicleID != -1;
        }

        private bool _UpdateVehicle()
        {
            return clsVehicleDataAccess.UpdateVehicle(
                VehicleID, MakeID, ModelID, Year,
                FuelID, CategoryID, Plate, Mileage, Price, ImagePath);
        }

        public static bool Delete(int ID)
        {
            return clsVehicleDataAccess.DeleteVehicle(ID);
        }

        public static DataTable ListVehicles()
        {
            return clsVehicleDataAccess.GetAllVehicles();
        }

        public static DataTable ListMakes()
        {
            return clsVehicleDataAccess.GetAllMakes();
        }



        public static bool SetAvailability(int vehicleID, bool isAvailable)
        {
            return clsVehicleDataAccess.SetVehicleAvailability(vehicleID, isAvailable);
        }


        public static bool UpdateMileage(int vehicleID, int mileage)
        {
            return clsVehicleDataAccess.UpdateMileage(vehicleID, mileage);
        }

        public static DataTable GetAvailableVehicles()
        {
            return clsVehicleDataAccess.GetAvailableVehicles();
        }

        public static decimal GetPrice(int vehicleID)
        {
            return clsVehicleDataAccess.GetVehiclePrice(vehicleID);
        }



        public static int GetMileage(int vehicleID)
        {
            return clsVehicleDataAccess.GetVehicleMileage(vehicleID);
        }


        public static DataTable GetModelsByMake(int makeID)
        {
            return clsVehicleDataAccess.GetModels(makeID);
        }


        public static DataTable GetVehicleDetails(int vehicleID)
        {
            return clsVehicleDataAccess.GetVehicleDetails(vehicleID);
        }


        public static DataTable GetCategoriesByModel(int modelID)
        {
            return clsVehicleDataAccess.GetCategoriesByModel(modelID);
        }
        public static DataTable GetYearsByModelAndCategory(int modelID, int catid)
        {
            return clsVehicleDataAccess.GetYearsByModelAndCategory(modelID, catid);
        }

        public static DataTable GetFuelTypesByModelAndCategory(int modelID, int catid)
        {
            return clsVehicleDataAccess.GetFuelTypesByModelAndCategory(modelID, catid);
        }

        public static DataTable GetYearsByModelCategoryAndFuel(int modelID, int categoryID, int fuelID)
        {
            return clsVehicleDataAccess.GetYearsByModelCategoryAndFuel(modelID, categoryID, fuelID);
        }

    }
}