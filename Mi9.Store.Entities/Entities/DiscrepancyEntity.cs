using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class DiscrepancyEntity
    {
        public long DiscrepancyNumber { get;set;}

        public string PONumber { get; set; }

        public string ShipmentNumber { get; set; }

        public string TransferNumber { get; set; }

        public string CreatedBy { get; set;}

        public DateTime CreatedOn { get; set;}

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string ClosedBy { get; set; }

        public DateTime? ClosedOn { get; set; }

        public string Notes { get; set; }

        public virtual ICollection<DiscrepancyDetailEntity> Details { get; set; }

        public virtual PurchaseOrderEntity PurchaseOrder { get; set; }

        public virtual ShipmentEntity Shipment { get; set; }

        public virtual TransferEntity Transfer { get; set; }
        
    }
}


