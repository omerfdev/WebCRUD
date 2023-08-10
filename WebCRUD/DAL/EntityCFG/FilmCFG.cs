using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCRUD.Models;

namespace WebCRUD.DAL.EntityCFG
{
    public class FilmCFG : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            

            builder.HasData(
                new Film { FilmID = 1, FilmName = "G.O.R.A.", Description = "Bir Uzay Filmi", CategoryID = 1, Duration = 109 },
                   new Film { FilmID = 2, FilmName = "Installer", Description = "Uzay Filmi", CategoryID = 2, Duration = 109 }

                );
        }
    }
}
