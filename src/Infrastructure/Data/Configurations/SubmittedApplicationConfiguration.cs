using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class SubmittedApplicationConfiguration : IEntityTypeConfiguration<SubmittedApplication>
    {
        public void Configure(EntityTypeBuilder<SubmittedApplication> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Status)
                .HasConversion<string>()
                .IsRequired();

            builder.Property(a => a.ApplicantId)
                .IsRequired();

            builder.Property(a => a.CollegeId)
                .IsRequired();

            builder.Property(a => a.AcademicProgramId)
                .IsRequired();

            builder.HasMany<ApplicationDocument>()
                .WithOne()
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<ApplicationStatusHistory>()
                .WithOne()
                .HasForeignKey(h => h.ApplicationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
