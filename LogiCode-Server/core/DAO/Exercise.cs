using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAO
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Instruction { get; set; }
        public int Points { get; set; }

        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }

    }
}
