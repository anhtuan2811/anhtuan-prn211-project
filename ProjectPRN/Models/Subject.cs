using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Exercises = new HashSet<Exercise>();
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Semester { get; set; }
        public string MajorsId { get; set; }

        public virtual Major Majors { get; set; }
        public virtual ICollection<Exercise> Exercises { get; set; }
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
