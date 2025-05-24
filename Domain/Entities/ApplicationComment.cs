using Domain.Common;

namespace Domain.Entities
{
    public class ApplicationComment : BaseAuditableEntity<Guid>
    {
        public Guid ApplicationId { get; set; }
        public string? Comment { get; set; }
    }
}
