using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsReturn
    {
        public int BookingID { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Days { get; set; }

        public int Mileage { get; set; }
        public int Consumed { get; set; }

        public string Notes { get; set; }

        public decimal ExtraCharges { get; set; }
        public decimal Total { get; set; }

        public int ReturnID { get; private set; }

        public bool Save()
        {
            ReturnID = clsReturnDataAccess.AddReturn(
                BookingID, ReturnDate, Days,
                Mileage, Consumed,
                Notes, ExtraCharges, Total);

            if (ReturnID != -1)
            {


                
                int vehicleID = clsBooking.GetVehicleID(BookingID);

                //// Update vehicle mileage
                clsVehicle.UpdateMileage(vehicleID, Mileage);


                //  Make vehicle available again
                clsVehicle.SetAvailability(vehicleID, true);

                return true;
            }

            return false;
        }


        public static DataTable ListReturns()
        {
            return clsReturnDataAccess.GetAllReturns();
        }

        public static bool Delete(int returnID)
        {
            return clsReturnDataAccess.DeleteReturn(returnID);
        }
    }
}
