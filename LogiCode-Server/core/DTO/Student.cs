using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class Student:User
    {
        public List<StudentCourse> StudentCourseIds { get; set; }
        public List<StudentLesson> StudentLessonIds { get; set; }



    }
}
