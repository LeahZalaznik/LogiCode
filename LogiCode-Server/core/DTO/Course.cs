using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public enum eLevel{easy=1,medןum=2,hard=4}
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProgrammingLanguage { get; set; }
        public int DurationHours { get; set; }
        public decimal Price { get; set; }
        public eLevel DurationMinutes { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Points {  get; set; } 
        public List<Lesson> Lessons { get; set; }


    }
}
