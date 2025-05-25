using Domain.Common;
using Domain.Enum;

namespace Domain.Entities
{
    public class SubmittedApplication : BaseAuditableEntity<Guid>
    {
        public Guid ApplicantId { get; set; }
        public Guid ConsultantId { get; set; }
        public Guid CollegeId { get; set; }
        public Guid AcademicProgramId { get; set; }
        public ApplicationStatus Status { get; set; }
        public DateTime SubbmittedAt { get; set; }
    }
}
