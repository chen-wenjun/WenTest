using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class PoTrackingEntryEntity
    {
        public string PONumber { get; set; }
        public int? OrderNumber { get; set; }
        public string Notes { get; set; }
        
        public virtual PurchaseOrderEntity PurchaseOrder { get; set; }
        public virtual OrderEntity CustomerOrder { get; set; }
        
        public virtual ICollection<PoTrackingDetailEntity> States { get; set; }
        public virtual ICollection<PoTrackingLogEntity> Logs { get; set; }
        public virtual ICollection<PoTrackingEmailAttachmentEntity> Attachments { get; set; }

        public PoTrackingEntryEntity() {
            States = new List<PoTrackingDetailEntity>();
            Logs = new List<PoTrackingLogEntity>();
            Attachments = new List<PoTrackingEmailAttachmentEntity>();
        }
    }
}
