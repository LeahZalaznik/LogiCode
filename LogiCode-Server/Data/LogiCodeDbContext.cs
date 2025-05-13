using Core.DAO;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class LogiCodeDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }

        public LogiCodeDbContext(DbContextOptions<LogiCodeDbContext> options) : base(options) { }

    }
}
