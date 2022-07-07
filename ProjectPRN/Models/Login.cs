using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
    }
}
