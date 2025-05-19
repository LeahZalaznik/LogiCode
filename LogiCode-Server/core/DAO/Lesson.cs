using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAO
{
    public class Lesson
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string? VideoUrl { get; set; } 

        public Course Course { get; set; }
        public Exercise Exercise { get; set; }
        public ICollection<StudentLesson> StudentLessons { get; set; }

    }
}
