using Core.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAO
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProgrammingLanguage { get; set; }
        public int TeacherId { get; set; }
        public int DurationHours { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public eLevel DurationMinutes { get; set; }
        public List<string> Points { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
