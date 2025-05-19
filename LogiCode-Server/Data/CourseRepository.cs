using Core.DAO;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CourseRepository : ICourseRepository
    {
        private readonly LogiCodeDbContext _context;
        private readonly ICourseRepository _courseRepository;

        public CourseRepository(LogiCodeDbContext context)
        {
            _context = context;
        }
        public async Task<Course> AddAsync(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return course;
        }
        public async Task<Course> GetByIdAsync(int courseId)
        {
            return await _courseRepository.GetByIdAsync(courseId);
        }


        public Task<List<Course>> GetByUserAsync(string userId)
        { 
            List<Course> cou=new List<Course> { };
            List<StudentCourse> courses = (List<StudentCourse>)_context.studentCourses.Where(a=>a.Id.Equals( userId));
             foreach (StudentCourse course in courses)
            {
                cou.Add(course.Course);
            }
            return Task.FromResult(cou);
        }


        public Task<Course> UpdateAsync(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
