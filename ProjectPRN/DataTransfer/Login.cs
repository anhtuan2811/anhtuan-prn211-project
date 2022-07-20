using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.DataTransfer
{
    class Login
    {       
            public string Username { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Role { get; set; }

        public Login()
        {
        }
        public Login(string username, string password, string name, string gender, string role)
        {
            Username = username;
            Password = password;
            Name = name;
            Gender = gender;
            Role = role;
        }
    }

}
