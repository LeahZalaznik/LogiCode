using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class StudentLesson
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public bool IsWatched { get; set; }
        public DateTime? WatchedOn { get; set; }
        public double? ExerciseScore { get; set; }
    }
}
