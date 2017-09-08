using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class UserModel
    {
        public int c_id { get; set; }
        public string c_name { get; set; }
        public string c_mobile { get; set; }
        public string c_email { get; set; }
        public string c_gender { get; set; }
        public string c_age { get; set; }

        public static List<UserModel> getUsers()
        {
            List<UserModel> Users = new List<UserModel>()
            {
                new UserModel(){c_id=1,c_name="manoj",c_mobile="1010101010",c_email="m@gmail.com",c_gender="MALE",c_age="21"}
            };
            return Users;
        }
    }
}