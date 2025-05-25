using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class ApplicationStatusHistoryConfiguration : IEntityTypeConfiguration<ApplicationStatusHistory>
    {
        public void Configure(EntityTypeBuilder<ApplicationStatusHistory> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.ApplicationId)
                .IsRequired();

            builder.Property(h => h.Status)
                .HasConversion<string>()
                .IsRequired();
        }
    }
}
