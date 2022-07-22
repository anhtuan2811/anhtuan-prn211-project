using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.DataTransfer
{
    class Class
    {
        public string ClassID { get; set; }
        public string MajorsID { get; set; }
        public string ClassName { get; set; }

        public Class()
        {
        }

        public Class(string classID, string className)
        {
            ClassID = classID;
            ClassName = className;
        }

        public Class(string classID, string majorsID, string className)
        {
            ClassID = classID;
            MajorsID = majorsID;
            ClassName = className;
        }
    }
}
