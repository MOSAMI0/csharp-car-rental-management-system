using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsUser
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }

        public static clsUser Find(string username, string password)
        {
            int userID = -1;
            string role = "";

            if (clsUserDataAccess.GetUserByUsernameAndPassword(
                username, password, ref userID, ref role))
            {
                return new clsUser
                {
                    UserID = userID,
                    Username = username,
                    Role = role
                };
            }
            else
                return null;
        }
    }
}
