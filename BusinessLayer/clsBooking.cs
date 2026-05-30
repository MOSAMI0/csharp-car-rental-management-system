using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsBooking
    {
        public int BookingID { get; set; }

        public int CustomerID { get; set; }
        public int VehicleID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Pickup { get; set; }
        public string Dropoff { get; set; }

        public int Days { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal Total { get; set; }

        public string Notes { get; set; }

        public int StartMileage { get; set; }

        public bool Save()
        {
            BookingID = clsBookingDataAccess.AddBooking(
                CustomerID, VehicleID,
                StartDate, EndDate,
                Pickup, Dropoff,
                Days, PricePerDay, Total, Notes, StartMileage);

            if (BookingID != -1)
            {
                clsVehicle.SetAvailability(VehicleID, false);
                return true;
            }

            return false;
        }

        public static DataTable ListBookings()
        {
            return clsBookingDataAccess.GetAllBookings();
        }

        public static bool Delete(int bookingID)
        {
            // 1. Get vehicle before deleting
            int vehicleID = clsBookingDataAccess.GetVehicleIDByBooking(bookingID);

            if (vehicleID == -1)
                return false;

            // 2. Delete booking
            if (clsBookingDataAccess.DeleteBooking(bookingID))
            {
                // 3. Make vehicle available again
                clsVehicle.SetAvailability(vehicleID, true);
                return true;
            }

            return false;
        }

        public static int GetVehicleID(int bookingID)
        {
            return clsBookingDataAccess.GetVehicleIDByBooking(bookingID);
        }

        public static DateTime GetStartDate(int bookingID)
        {
            return clsBookingDataAccess.GetStartDate(bookingID);
        }

      
        public static DataTable GetBookingByID(int bookingID)
        {
            return clsBookingDataAccess.GetBookingDetails(bookingID);
        }

        public static DataTable GetActiveBookings()
        {
            return clsBookingDataAccess.GetActiveBookings();
        }

        public static DataTable ListActiveBookings()
        {
            return clsBookingDataAccess.ListActiveBookings();
        }

    }
}
