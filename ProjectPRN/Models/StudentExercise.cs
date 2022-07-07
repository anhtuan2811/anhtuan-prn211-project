using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class StudentExercise
    {
        public string ExerciseName { get; set; }
        public string StudentId { get; set; }
        public string Marks { get; set; }

        public virtual Exercise ExerciseNameNavigation { get; set; }
        public virtual Student Student { get; set; }
    }
}
