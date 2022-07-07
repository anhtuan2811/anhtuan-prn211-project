using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Major
    {
        public Major()
        {
            Classes = new HashSet<Class>();
            Subjects = new HashSet<Subject>();
        }

        public string MajorsId { get; set; }
        public string MajorsName { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
