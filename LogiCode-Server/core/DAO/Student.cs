using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAO
{
    public class Student :User
    {
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<StudentLesson> StudentLessons { get; set; }

    }
}
                                                                            