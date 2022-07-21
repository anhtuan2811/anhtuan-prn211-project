using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.DataTransfer
{
    class Teacher
    {
        public string TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Teacher()
        {
        }

        public Teacher(string teacherID, string teacherName, string gender, string phoneNumber, string email)
        {
            TeacherID = teacherID;
            TeacherName = teacherName;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
