using System;

namespace Mi9.Store.Entities.Entities
{
    public class PurchaseOrderItemEntity
    {
        public PurchaseOrderItemEntity()
        {
            ItemStatCode = "A";
            SpanishDesc = string.Empty;
            SOIDtlStat = "Y";
            Description = string.Empty;
            ItemStatus = "O"; // this is the default value in the db
        }
        public string PurchaseOrderNumber { get; set; }
        public int PurchaseOrderSeqNumber { get; set; }
        public long? SKU { get; set; }
        public string Description { get; set; }
        public string SpanishDesc { get; set; }
        public string EngDesc { get; set; }
        public short VendorPack { get; set; }
        public string VendorUOM { get; set; }
        public string PalletID { get; set; }
        public decimal OrderQty { get; set; }
        public int SuggestQty { get; set; }
        public virtual ItemSkuEntity ItemSku { get; set; }
        public virtual PurchaseOrderEntity PurchaseOrder { get; set; }
        public virtual PalletEntity Pallet { get; set; }
        public short? DepartmentId { get; set; }
        public short? ClassId { get; set; }
        public short? SubClass { get; set; }
        public virtual CategoryEntity Category { get; set; }
        public string ItemStatCode { get; set; }
        public TimeSpan? POCreateTime { get; set; }
        public decimal? UnitCube { get; set; }
        public int OrderNumber { get; set; }
        public string SOIDtlStat { get; set; }
        public decimal ConDamageQty { get; set; }
        public decimal TotQtyRecvd { get; set; }
        public string ItemStatus { get; set; }
        public decimal TotQtyToday { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? UnitFreight { get; set; }
        public decimal CollectCost { get; set; }
        public decimal? PrepaidCost { get; set; }

        #region LegacyFields
        //public short? RevisionNo { get; set; }
        //public DateTime? RevisionDate { get; set; }
        //public decimal? UnitWt { get; set; }
        //public string UOM { get; set; }
        //public short? ReceiverSub { get; set; }
        //public DateTime? LastRecDate { get; set; }
        //public decimal? TotQtyToday { get; set; }
        //public decimal? LastRecQty { get; set; }
        //public decimal? UnitCostPre { get; set; }
        //public DateTime? KeyedDate { get; set; }
        //public bool? PrimaryVend { get; set; }
        //public decimal? MemoQtyRecd { get; set; }
        //public decimal? RetailPrice { get; set; }
        //public decimal? OrigAveCost { get; set; }
        //public decimal? OrigLastCost { get; set; }
        //public string MemoStatus { get; set; }
        //public decimal? MemoCost { get; set; }
        //public string LastStatus { get; set; }
        //public int? ReceiverNum { get; set; }
        //public bool? PrintFlag { get; set; }
        //public short? LineNumber { get; set; }
        //public bool? ReadyForUpl { get; set; }
        //public DateTime? CommsDate { get; set; }
        //public string SOInfo { get; set; }
        //public byte? ExceptReason__1 { get; set; }
        //public byte? ExceptReason__2 { get; set; }
        //public byte? ExceptReason__3 { get; set; }
        //public byte? ExceptReason__4 { get; set; }
        //public decimal? ExceptQty__1 { get; set; }
        //public decimal? ExceptQty__2 { get; set; }
        //public decimal? ExceptQty__3 { get; set; }
        //public decimal? ExceptQty__4 { get; set; }
        //public string NofUPC { get; set; }
        //public string Planogram { get; set; }
        //public int? PlanoSequence { get; set; }
        //public long? SubSKU { get; set; }
        //public bool? RecCreate { get; set; }
        //public bool? OnFlyFlag { get; set; }
        //public decimal? ExchangeRate { get; set; }
        //public bool? ItemRevFlag { get; set; }
        //public bool? CommodItem { get; set; }
        //public bool? UpdateInvFlg { get; set; }
        //public bool? CollCostChge { get; set; }
        //public bool? PPDCostChge { get; set; }
        //public decimal? PackSlipQty { get; set; }
        //public decimal? VisShortQty { get; set; }
        //public decimal? ConShortQty { get; set; }
        //public decimal? VisDamageQty { get; set; }
        //public decimal? LastPackSlip { get; set; }
        //public decimal? LastVisShort { get; set; }
        //public decimal? LastConShort { get; set; }
        //public decimal? LastVisDamag { get; set; }
        //public decimal? LastConDamag { get; set; }
        //public int? CustOrdrNumb { get; set; }
        //public short? CustOrderSeq { get; set; }
        //public long? GLAccount { get; set; }
        //public string BinLocation { get; set; }
        //public string EngDesc { get; set; }
        //public string SpanishDesc { get; set; }
        #endregion
    }
}