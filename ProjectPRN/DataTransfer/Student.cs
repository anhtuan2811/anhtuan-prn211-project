using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.DataTransfer
{
    class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ClassID { get; set; }

        public Student()
        {
        }

        public Student(string studentID, string studentName, DateTime dOB, string gender, string email, string address, string classID)
        {
            StudentID = studentID;
            StudentName = studentName;
            DOB = dOB;
            Gender = gender;
            Email = email;
            Address = address;
            ClassID = classID;
        }
    }
}
