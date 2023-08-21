using ManyToManyMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManyToManyMVC.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
