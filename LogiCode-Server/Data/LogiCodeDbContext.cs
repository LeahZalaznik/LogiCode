using Core.DAO;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class LogiCodeDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<StudentLesson> studentLessons { get; set; }    
        public DbSet<Payment> payment { get; set; }
        public DbSet<Lesson> lessons { get; set; }

        public LogiCodeDbContext(DbContextOptions<LogiCodeDbContext> options) : base(options) { }

    }
}
