using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCRUD.Models;

namespace WebCRUD.DAL.EntityCFG
{
    public class CategoryCFG : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           
            builder.Property(x=>x.CategoryName).IsRequired().HasMaxLength(80).HasColumnType("nvarchar");
            builder.HasData(
                new Category { CategoryID = 1, CategoryName = "Drama" },
                new Category { CategoryID = 2, CategoryName = "Action" },
                 new Category { CategoryID = 3, CategoryName = "Biography" }
                );
        }
    }
}
