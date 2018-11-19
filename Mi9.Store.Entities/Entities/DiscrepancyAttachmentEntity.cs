using System;

namespace Mi9.Store.Entities.Entities
{
    public class DiscrepancyAttachmentEntity
    {
        public long Id { get; set; }

        public long DiscrepancyDetailId { get; set; }

        public string Url { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DiscrepancyDetailEntity DiscrepancyDetail { get; set; }
    }
}
