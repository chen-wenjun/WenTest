using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class TransferEntity
    {
        public string TransferNumber { get; set; }

        public string Status { get; set; }

        public short? RequestStore { get; set; }

        public short? SourceStore { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateApproved { get; set; }

        public DateTime? DateShipped { get; set; }

        public DateTime? DateVoided { get; set; }

        public DateTime? DateReceived { get; set; }

        public DateTime? ReqShipDate { get; set; }

        public string Note { get; set; }

        public byte? ReasonCode { get; set; }

        public string ShipMethod { get; set; }

        public string CreateEmp { get; set; }

        public string AmendEmp { get; set; }

        public string ApproveEmp { get; set; }

        public string ShippedEmp { get; set; }

        public string VoidedEmp { get; set; }

        public string ReceivedEmp { get; set; }

        public string OrigSuggestionNumber { get; set; }

        public string ShipmentRef { get; set; }

        public string DriverRef { get; set; }

        public string TruckNumber { get; set; }

        public DateTime? DateLastUpd { get; set; }

        public bool HOInitiated { get; set; }

        public virtual ICollection<TransferItemEntity> TransferItems { get; set; }

        public virtual ICollection<ShipmentEntity> Shipments { get; set; }

        public virtual StoreEntity StoreSourceEntity { get; set; }

        public virtual StoreEntity StoreRequestEntity { get; set; }

        public virtual ICollection<DiscrepancyEntity> Discrepancies { get; set; } 
    }
}