using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        public string TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
