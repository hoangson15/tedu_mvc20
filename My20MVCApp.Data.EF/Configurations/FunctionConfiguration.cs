using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My20MVCApp.Data.EF.Extensions;
using My20MVCApp.Data.Entities;

namespace My20MVCApp.Data.EF.Configurations
{
    public class FunctionConfiguration : DbEntityConfiguration<Function>
    {
        public override void Configure(EntityTypeBuilder<Function> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id)
                .IsRequired()
                .HasMaxLength(128)
                .IsUnicode(false);
            // etc.
        }
    }
}
