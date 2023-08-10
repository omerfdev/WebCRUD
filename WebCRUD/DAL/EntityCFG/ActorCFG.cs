using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCRUD.Models;

namespace WebCRUD.DAL.EntityCFG
{
    public class ActorCFG : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
         

            builder.HasData(
             new Actor { ActorID = 1, FirstName = "Cem", LastName = "YILMAZ" },
             new Actor { ActorID = 2, FirstName = "Özkan", LastName = "UĞUR" },
             new Actor { ActorID = 3, FirstName = "Matt", LastName = "Damon" }
             );
        }
    }
}
