using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.DataTransfer
{
    class Majors
    {
        public string MajorsID { get; set; }
        public string MajorsName { get; set; }

        public Majors()
        {
        }

        public Majors(string majorsID, string majorsName)
        {
            MajorsID = majorsID;
            MajorsName = majorsName;
        }
    }
}
