using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public class clsMaintenance
    {
        public int VehicleID { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public bool Save()
        {
            int id = clsMaintenanceDataAccess.AddMaintenance(
                VehicleID, Description, Cost);

            if (id != -1)
            {
                clsVehicle.SetAvailability(VehicleID, false);
                return true;
            }

            return false;
        }

        public static DataTable ListMaintenance()
        {
            return clsMaintenanceDataAccess.ListMaintenance();
        }

        public static DataTable ListMaintenanceHistory()
        {
            return clsMaintenanceDataAccess.ListMaintenanceHistory();
        }


        public static bool Complete(int maintenanceID)
        {
            int vehicleID = clsMaintenanceDataAccess.GetVehicleID(maintenanceID);

            if (vehicleID == -1)
                return false;

            if (clsMaintenanceDataAccess.CompleteMaintenance(maintenanceID))
            {
                clsVehicle.SetAvailability(vehicleID, true);
                return true;
            }

            return false;
        }
    }
}