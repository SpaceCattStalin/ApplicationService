using Domain.Common;
using Domain.Enum;

namespace Domain.Entities
{
    public class ApplicationStatusHistory : BaseAuditableEntity<Guid>
    {
        public Guid ApplicationId { get; set; }
        public ApplicationStatus Status { get; set; }

    }
}
