using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    public class clsCustomer
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string ContactInformation { get; set; }
        public string DriverLicenseNumber { get; set; }

        public string ImagePath { get; set; }

        public clsCustomer()
        {
            CustomerID = -1;
            Name = "";
            ContactInformation = "";
            DriverLicenseNumber = "";
            ImagePath = "";
            Mode = enMode.AddNew;
        }

        private clsCustomer(int id, string name, string contact, string license, string imagePath)
        {
            CustomerID = id;
            Name = name;
            ContactInformation = contact;
            DriverLicenseNumber = license;
            ImagePath = imagePath; 
            Mode = enMode.Update;
        }

        public static clsCustomer Find(int ID)
        {
            string name = "", contact = "", license = "", imagePath = ""; ;

            if (clsCustomerDataAccess.GetCustomerByID(ID,
                ref name, ref contact, ref license, ref imagePath))
            {
                return new clsCustomer(ID, name, contact, license, imagePath);
            }
            else
                return null;
        }


        private bool _AddNewCustomer()
        {
            CustomerID = clsCustomerDataAccess.AddNewCustomer(Name, ContactInformation, DriverLicenseNumber, ImagePath );
            return CustomerID != -1;
        }
        private bool _UpdateCustomer()
        {
            return clsCustomerDataAccess.UpdateCustomer(CustomerID, Name, ContactInformation, DriverLicenseNumber, ImagePath);
        }


        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCustomer())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;
                case enMode.Update:
                    return _UpdateCustomer();
                default:
                    return false;
            }

        }

        public static bool Delete(int ID)
        {
            return clsCustomerDataAccess.DeleteCustomer(ID);
        }

        public static DataTable ListCustomers()
        {
            return clsCustomerDataAccess.ListCustomers();
        }
    }
}
