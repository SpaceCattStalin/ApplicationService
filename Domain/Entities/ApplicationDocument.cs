using Domain.Common;
using Domain.Enum;

namespace Domain.Entities
{
    public class ApplicationDocument : BaseAuditableEntity<Guid>
    {
        public Guid ApplicationId { get; set; }
        public string FileName { get; set; } = default!;
        public string FilePath { get; set; } = default!;
        public DocumentType Type { get; set; }
    }
}
