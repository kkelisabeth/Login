using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM4_Program3
{
    //User Class which has Password and Username getter and setter and the User Constructor 
    class User
    {
            public string Password { get; set; }
            public string Username { get; set; }

        public User(string password, string username)
        {
            Password = password;
            Username = username;
        }
    }
}
