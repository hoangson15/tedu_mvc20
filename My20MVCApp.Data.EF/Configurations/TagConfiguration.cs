using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My20MVCApp.Data.EF.Extensions;
using My20MVCApp.Data.Entities;

namespace My20MVCApp.Data.EF.Configurations
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("varchar(50)");
        }
    }
}
