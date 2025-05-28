using Core.DAO;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class LogiCodeDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentLesson> StudentLessons { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<MyTask> MyTasks { get; set; }
        public LogiCodeDbContext(DbContextOptions<LogiCodeDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=.;Database=LogiCodeDb;Trusted_Connection=True;TrustServerCertificate=True;");
        //    }

        //}
    }
}
