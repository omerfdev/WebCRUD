using Microsoft.EntityFrameworkCore;
using WebCRUD.DAL.EntityCFG;
using WebCRUD.Models;


namespace WebCRUD.DAL
{
    public class FilmDBContext:DbContext
    {
        public FilmDBContext(DbContextOptions<FilmDBContext>options):base(options)
        {
            
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<FilmActor> FilmActor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Lazy Loading...
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new CategoryCFG());
            modelBuilder.ApplyConfiguration<Actor>(new ActorCFG());
            modelBuilder.ApplyConfiguration<Film>(new FilmCFG());                
            modelBuilder.ApplyConfiguration<FilmActor>(new FilmActorCFG());
            base.OnModelCreating(modelBuilder);
        }
    }
}
