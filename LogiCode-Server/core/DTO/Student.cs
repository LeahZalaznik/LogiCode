using Core.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.DTO
{
    public class Student:User
    {
        public int Id { get; set; }
        public string? GoogleId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PotoUrl { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public List<StudentLesson> StudentLessons { get; set; }

        public List<MyTask> StudentTasks  { get; set; }



}
}
