using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class Student:User
    {
        public List<StudentCourse> StudentCourses { get; set; }
        public List<StudentLesson> StudentLessons { get; set; }



    }
}
