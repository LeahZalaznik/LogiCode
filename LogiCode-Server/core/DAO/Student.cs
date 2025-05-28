using Core.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAO
{
    public class Student 
    {
        public int Id { get; set; }
        public string? GoogleId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PotoUrl { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<StudentLesson> StudentLessons { get; set; }
        public ICollection<Core.DAO.MyTask> StudentTasks { get; set; }


    }
}
                                                                            