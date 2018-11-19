using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mi9.Store.Entities.Entities
{
   
    public class PurchaseOrderEntity
    {
        private ICollection<PurchaseOrderItemEntity> _purchaseOrderItems;
        public PurchaseOrderEntity()
        {
            //ShipmentTerm = "B";
            //Type = "R";
            //PoTypeId = "REGU";
            //POItmUseCode = "A";
            //CountryState = string.Empty;
            //VendAddress = string.Empty;
            //ShipVia = string.Empty;
            //SpecialInstructions1 = string.Empty;
            //SpecialInstructions2 = string.Empty;
            //CancelReason = string.Empty;
            //SOIFlag = true;
            //SOIHdrStat = "Y";
            //Notes = string.Empty;
            //OrderDate = new DateTime(DateTime.UtcNow.Ticks, DateTimeKind.Unspecified);
        }
        public string PurchaseOrderNumber { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public string SpecialInstructions1 { get; set; }
        public string SpecialInstructions2 { get; set; }
        public string ShipVia { get; set; }
        public string ShippingInstructions { get; set; }
        public DateTime? CancellationDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? OrderDate { get; set; } //is TransmitDate in DataBase
        public string VendorId { get; set; }
        public byte? VendorSuffix { get; set; }
        public bool Authorized { get; set; }
        public DateTime? AuthorizedDate { get; set; }
        public virtual VendorEntity Vendor { get; set; }
        public short? DestinationCode { get; set; }
        public virtual DestinationEntity Destination { get; set; }
        public short? DepartmentId { get; set; }
        public virtual DepartmentEntity Department { get; set; }
        public string PoTypeId { get; set; }
        public string SettlementTermId { get; set; }
        public InvoiceTermEntity SettlementTerm { get; set; }
        public string FobTermId { get; set; }
        public FobTermEntity FobTerm { get; set; }
        public string PaymentMethodId { get; set; }
        public PaymentMethodEntity PaymentMethod { get; set; }
        public bool IsSystemGenerated { get; set; }
        public bool AllowStoreCancellation { get; set; }
        public bool AllowStoreReActivation { get; set; }
        public int? OrderNumber { get; set; }
        public OrderEntity CustomerOrder { get; set; }
        public virtual ICollection<PurchaseOrderItemEntity> PurchaseOrderItems
        {
            get
            {
                return _purchaseOrderItems = _purchaseOrderItems ?? new Collection<PurchaseOrderItemEntity>();
            }

            set
            {
                _purchaseOrderItems = value;
            }
        }
        public string CountryState { get; set; }
        public string SOIHdrStat { get; set; }
        public bool SOIFlag { get; set; }
        public string CancelReason { get; set; }
        public string ShipmentTerm { get; set; }
        public string POItmUseCode { get; set; }
        public string FrtCarrier { get; set; }
        public byte? FrtCarSuffix { get; set; }
        public string VendAddress { get; set; }
        public int? BuyingDiv { get; set; }
        public DateTime? PrintedDate { get; set; }
        public DateTime? StatusChngDt { get; set; }
        public DateTime? LastRecDate { get; set; }
        public DateTime? RevisionDate { get; set; }
        public int? RevisedBy { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public int? ConfirmedBy { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string APMessage__1 { get; set; }
        public virtual EmployeeEntity Employee { get; set; }
        public virtual ICollection<ShipmentEntity> Shipments { get; set; }
        public virtual ICollection<DiscrepancyEntity> Discrepancies { get; set; }
        public PoTrackingEntryEntity PoTracking { get; set; }

        #region LegacyFields
        //public short? RevisionNo { get; set; }
        //public DateTime? ExpectDate { get; set; }
        //public decimal? TotalAmount { get; set; }
        //public decimal? FreightTot { get; set; }
        //public decimal? ReceivedTot { get; set; }
        //public decimal? WeightTot { get; set; }
        //public decimal? UnitTot { get; set; }
        //public decimal? CartonTot { get; set; }
        //public decimal? FreightPct { get; set; }
        //public short? DamagedCart { get; set; }
        //public bool? FOB { get; set; }
        //public DateTime? KeyedDate { get; set; }
        //public int? ReceiverNum { get; set; }
        //public short? ReceiverSub { get; set; }
        //public bool? RecTransmit { get; set; }
        //public bool? BackOrder { get; set; }
        //public bool? VendPrepdFlg { get; set; }
        //public decimal? TotalRetail { get; set; }
        //public int? LinesOpen { get; set; }
        //public int? RecPrcBtch { get; set; }
        //public bool? ReadyForUpl { get; set; }
        //public DateTime? CommsDate { get; set; }
        //public string Zip { get; set; }
        //public short? LinesToPost { get; set; }
        //public short? RegisterID { get; set; }
        //public int? TranNumber { get; set; }
        //public string Shipnumber { get; set; }
        //public string ShipBusName { get; set; }
        //public string ShipFirstName { get; set; }
        //public string ShipMidInit { get; set; }
        //public string ShipLastName { get; set; }
        //public string ShipToAdd1 { get; set; }
        //public string ShipToAdd2 { get; set; }
        //public string ShipToCity { get; set; }
        //public string ShipToState { get; set; }
        //public string ShipToZip { get; set; }
        //public bool? SOQFlag { get; set; }
        //public string Addr3 { get; set; }
        //public string ShipToAdd3 { get; set; }
        //public bool? OnFlyFlag { get; set; }
        //public int? LstProcSeqNo { get; set; }
        //public string VendorName { get; set; }
        //public int? SpdSaleNo { get; set; }
        //public short? PalletIn { get; set; }
        //public short? PalletOut { get; set; }
        //public string POGuide { get; set; }
        //public string POMaster { get; set; }
        //public string POStatBb { get; set; }
        //public bool? FreeAstray { get; set; }
        //public bool? FirstItemRec { get; set; }
        //public bool? VenPPDMinMet { get; set; }
        //public bool? VenRegMinMet { get; set; }
        //public bool? POTransmit { get; set; }
        //public bool? RecLogged { get; set; }
        //public bool? InUseCode { get; set; }
        //public DateTime? PromoDate { get; set; }
        //public DateTime? CorpAckDate { get; set; }
        //public DateTime? RecAssigDate { get; set; }
        //public DateTime? OrigRecdDate { get; set; }
        //
        //public DateTime? FrtBillDate { get; set; }
        //public decimal? POTotCollAmt { get; set; }
        //public decimal? POTotFrtAmt { get; set; }
        //public decimal? POTotPPDAmt { get; set; }
        //public decimal? NewStoreDisc { get; set; }
        //
        //public string APMessage__2 { get; set; }
        //public string APMessage__3 { get; set; }
        //public string APMessage__4 { get; set; }
        //public string CarrierNumb { get; set; }
        //public byte? CarrierSuffix { get; set; }
        #endregion
    }
}