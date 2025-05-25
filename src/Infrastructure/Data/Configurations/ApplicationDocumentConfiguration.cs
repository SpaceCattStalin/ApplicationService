using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class ApplicationDocumentConfiguration : IEntityTypeConfiguration<ApplicationDocument>
    {
        public void Configure(EntityTypeBuilder<ApplicationDocument> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.ApplicationId)
                .IsRequired();

            builder.Property(d => d.FileName)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(d => d.FilePath)
                .HasMaxLength(512)
                .IsRequired();

            builder.Property(d => d.Type)
                .HasConversion<string>()
                .IsRequired();
        }
    }
}
