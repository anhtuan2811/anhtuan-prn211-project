using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class Exercise
    {
        public Exercise()
        {
            StudentExercises = new HashSet<StudentExercise>();
        }

        public string ExerciseName { get; set; }
        public string Percentage { get; set; }
        public string SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual ICollection<StudentExercise> StudentExercises { get; set; }
    }
}
