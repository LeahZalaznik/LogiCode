using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProgrammingLanguage { get; set; }
        public int DurationHours { get; set; }
        public decimal Price { get; set; }
        public List<int>LessonIds { get; set; }


    }
}
