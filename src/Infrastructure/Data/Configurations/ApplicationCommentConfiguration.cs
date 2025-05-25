using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class ApplicationCommentConfiguration : IEntityTypeConfiguration<ApplicationComment>
    {
        public void Configure(EntityTypeBuilder<ApplicationComment> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.ApplicationId)
                .IsRequired();

            builder.Property(c => c.Comment)
                .HasMaxLength(1000);
        }
    }
}
