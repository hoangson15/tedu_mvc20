using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My20MVCApp.Data.EF.Extensions;
using My20MVCApp.Data.Entities;

namespace My20MVCApp.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id)
                .HasMaxLength(255)
                .IsRequired();
            // etc.
        }
    }
}
