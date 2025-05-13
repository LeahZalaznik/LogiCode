using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAO
{
    public class StudentLesson
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }

        public bool IsWatched { get; set; }
        public DateTime? WatchedOn { get; set; }
        public double? ExerciseScore { get; set; } 

    }
}
