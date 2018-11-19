using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class PalletEntity
    {
        public string PalletId { get; set; }

        public string AuditStatus { get; set; }

        public string ShipmentNumber { get; set; }

        public bool StretchWrap { get; set; }

        public bool Consolidation { get; set; }

        public bool GoodCondition { get; set; }

        public bool GoodTie { get; set; }

        public bool Error { get; set; }

        public bool StoreAudit { get; set; }

        public bool SystemAudit { get; set; }

        public bool AuditDetailChecked { get; set; }

        public DateTime? DateLastUpdated { get; set; }

        public string Type { get; set; }

        public string MasterLabel { get; set; }

        public string Notes { get; set; }

        public string StatusPS { get; set; }

        public virtual ShipmentEntity Shipment { get; set; }

        public virtual ICollection<PalletItemEntity> Items { get; set; }

        public bool Scanned { get; set; }

        public DateTime? PrintedLabelOriginalDate { get; set; }

        public int? CreatedById { get; set; }
        public virtual EmployeeEntity CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public int? UpdatedById { get; set; }
        public virtual EmployeeEntity UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        
        public int? ConfirmedById { get; set; }
        public virtual EmployeeEntity ConfirmedBy { get; set; }
        public DateTime? ConfirmedOn { get; set; }
    }
}