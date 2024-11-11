using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My20MVCApp.Data.EF.Extensions;
using My20MVCApp.Data.Entities;

namespace My20MVCApp.Data.EF.Configurations
{
    public class BlogTagConfiguration : DbEntityConfiguration<BlogTag>
    {
        public override void Configure(EntityTypeBuilder<BlogTag> entity)
        {
            entity.Property(c => c.TagId)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(false);
            // etc.
        }
    }
}
