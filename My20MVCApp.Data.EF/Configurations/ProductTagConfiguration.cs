using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My20MVCApp.Data.EF.Extensions;
using My20MVCApp.Data.Entities;

namespace My20MVCApp.Data.EF.Configurations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.TagId)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("varchar(50)");
            // etc.
        }
    }
}
