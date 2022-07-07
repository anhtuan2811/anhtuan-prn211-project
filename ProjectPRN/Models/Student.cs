using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentExercises = new HashSet<StudentExercise>();
        }

        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual ICollection<StudentExercise> StudentExercises { get; set; }
    }
}
