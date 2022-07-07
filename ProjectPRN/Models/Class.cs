using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public string ClassId { get; set; }
        public string MajorsId { get; set; }
        public string ClassName { get; set; }

        public virtual Major Majors { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
