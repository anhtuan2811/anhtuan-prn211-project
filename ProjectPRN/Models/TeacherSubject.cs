using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class TeacherSubject
    {
        public string TeacherId { get; set; }
        public string SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
