using Microsoft.EntityFrameworkCore;
using StudentClass.Models.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace StudentClass.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options ):base (options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}
