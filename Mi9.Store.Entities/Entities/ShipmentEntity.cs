// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShipmentEntity.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   The shipment entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class ShipmentEntity
    {
        public string ShipmentNumber { get; set; }

        public string ShipmentTypeId { get; set; }

        public virtual ShipmentTypeEntity ShipmentType { get; set; }

        public string Status { get; set; }

        public string AuditStatus { get; set; }

        public bool Verification { get; set; }

        public string TransferNumber { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public string VendorId { get; set; }
        public byte VendorSuffix { get; set; }
        public virtual VendorEntity Vendor {get; set; }

        public bool BOLMissing { get; set; }

        public bool CarrierBillMissing { get; set; }

        public bool PhotoMissing { get; set; }

        public bool ManifestMissing { get; set; }

        public bool TripLogMissing { get; set; }

        public bool ConsistentMarking { get; set; }

        public bool CatsWellPlaced { get; set; }

        public bool EnoughCats { get; set; }

        public bool BarsWellPlaced { get; set; }

        public bool EnoughBars { get; set; }

        public bool SuitableArrange { get; set; }

        public bool Error { get; set; }

        public DateTime? LastDateReceived { get; set; }

        public string Notes { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public DateTime? ConfirmedOn { get; set; }

        public virtual PurchaseOrderEntity PurchaseOrder { get; set; }

        public virtual TransferEntity Transfer { get; set; }

        public virtual ICollection<ShipmentItemEntity> ShipmentItems { get; set; }

        public virtual ICollection<PalletEntity> Pallets { get; set; }

        public virtual ICollection<DiscrepancyEntity> Discrepancies { get; set; } 

        public int CreatedById { get; set; }
        public virtual EmployeeEntity CreatedBy { get; set; }

        public int? UpdatedById { get; set; }
        public virtual EmployeeEntity UpdatedBy { get; set; }

        public int? ConfirmedById { get; set; }
        public virtual EmployeeEntity ConfirmedBy { get; set; }
    }
}