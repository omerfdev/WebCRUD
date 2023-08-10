using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCRUD.Models;

namespace WebCRUD.DAL.EntityCFG
{
    public class FilmActorCFG : IEntityTypeConfiguration<FilmActor>
    {
        public void Configure(EntityTypeBuilder<FilmActor> builder)
        {
            builder.ToTable("FilmActor");
        
            builder.HasData(
                new FilmActor { FilmID=1 ,FAID=1,ActorID=1},
                new FilmActor { FilmID=1 ,FAID=2,ActorID=2},
                new FilmActor { FilmID=2 ,FAID=3,ActorID=3}
                );
        }
    }


}
