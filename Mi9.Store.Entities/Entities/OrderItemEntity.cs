using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{
    public class OrderItemEntity
    {
        public OrderItemEntity()
        {
            CommentType = "R";
            EntrySource = "K";
            OptionCode = "P";
            OrderDetType = "M";
            OrderStatus = "A";
            TaxFlag = "P";
            TaxInd = "Y";
            SKUDesc = string.Empty;
            PriceCode = string.Empty;
            MiscNumber = string.Empty;
            CouponNumber = string.Empty;
            SerialNumber = string.Empty;
            UOMFlag = string.Empty;
            TaxCode = string.Empty;
            UPC = string.Empty;
            PickTake = string.Empty;
            VendorName = string.Empty;
            LineMessage = string.Empty;

            // TODO: Are these default values needed? Default empty string in DB
            VendorID = "1";
        }

        public int OrderNumber { get; set; }
        
        public short OrdSeqNumber { get; set; }
        
        public long? SKU { get; set; }
        
        public int? FeeCode { get; set; }

        [StringLength(35)]
        public string SKUDesc { get; set; }

        [StringLength(1)]
        public string PriceCode { get; set; }

        public byte PriceOvrType { get; set; }

        public decimal PriceAllow { get; set; }

        [StringLength(13)]
        public string MiscNumber { get; set; }

        [StringLength(16)]
        public string CouponNumber { get; set; }

        [StringLength(20)]
        public string SerialNumber { get; set; }

        public byte LineDiscType { get; set; }

        [StringLength(1)]
        public string DLType { get; set; }

        [StringLength(1)]
        public string OrderDetType { get; set; }

        [StringLength(1)]
        public string UOMFlag { get; set; }

        [StringLength(1)]
        public string TaxFlag { get; set; }

        public decimal ExtendedAmt { get; set; }

        public decimal ExtendedDisc { get; set; }

        public decimal SpreadDisc { get; set; }

        public decimal OrderDisc { get; set; }

        public decimal DiscPercent { get; set; }

        public decimal UnitDiscount { get; set; }

        [StringLength(12)]
        public string TaxCode { get; set; }

        public decimal TaxRate { get; set; }

        [StringLength(1)]
        public string OptionCode { get; set; }

        public DateTime? DelDate { get; set; }

        [StringLength(16)]
        public string UPC { get; set; }

        public decimal Quantity { get; set; }

        public short AtForQty { get; set; }

        public decimal QuantityOrd { get; set; }

        public bool Reserved { get; set; }

        [StringLength(1)]
        public string PickTake { get; set; }

        public short MoveDrag { get; set; }

        public short MoveElevation { get; set; }

        public decimal SellPrice { get; set; }

        public decimal RetailPrice { get; set; }

        public decimal UnitPrice { get; set; }

        public string PriceLabel { get; set; }

        public bool IsSpvApplied { get; set; }

        public decimal QuantitySold { get; set; }

        [StringLength(12)]
        public string VendorID { get; set; }

        public byte? VendorSuffix { get; set; }

        [StringLength(11)]
        public string VendPartNo { get; set; }

        [StringLength(35)]
        public string VendorName { get; set; }

        [StringLength(60)]
        public string LineMessage { get; set; }

        [NotMapped]
        public decimal Margin
        {
            get
            {
                if (ItemSku == null || !ItemSku.Cost.HasValue || RetailPrice == 0)
                {
                    return 0;
                }

                return (RetailPrice - ItemSku.Cost.Value) / RetailPrice * 100;
            }
        }

        [NotMapped]
        public decimal MarginAbs
        {
            get
            {
                if (ItemSku == null || !ItemSku.Cost.HasValue || RetailPrice == 0)
                {
                    return 0;
                }

                return RetailPrice - ItemSku.Cost.Value;
            }
        }

        public short DeptNo { get; set; }

        public short ClassNo { get; set; }

        public int? InstallationPackId { get; set; }

        public short? InstallationPackServiceSequence { get; set; }

        public int? InstallationServiceId { get; set; }

        public virtual InstallationPackDetailEntity InstallationPackDetail { get; set; }

        public int? RefundedRequestId { get; set; } 
        
        public virtual InstallationRequestEntity RefundedInstallationRequest { get; set; }

        public virtual OrderEntity Order { get; set; }

        public virtual ItemSkuEntity ItemSku { get; set; }

        public virtual FeeEntity Fee { get; set; }

        [StringLength(2)]
        public string DumpAdjustType { get; set; }
        
        [StringLength(4)]
        public string UOM { get; set; }

        [StringLength(1)]
        public string TaxInd { get; set; }

        [StringLength(1)]
        public string OrderStatus { get; set; }

        [StringLength(11)]
        public string PONumber { get; set; }

        [StringLength(1)]
        public string CommentType { get; set; }

        [StringLength(1)]
        public string EntrySource { get; set; }

        public decimal UnitCost { get; set; }

        public byte DeliveryType { get; set; }

        #region NotRequired
        //public string RecType { get; set; }

        //public string MiscType { get; set; }

        //public decimal? LineDiscount { get; set; }

        //public int? MiscAcct { get; set; }

        //public int? CommissEmp { get; set; }

        //public DateTime? DeliverDate { get; set; }

        //public string SOItemPOStat { get; set; }

        //public byte? OperatMode { get; set; }

        //public string DiscountCode { get; set; }

        //public int? ContractNo { get; set; }

        //public string ReserveType { get; set; }

        //public string CopySource { get; set; }

        //public string NotOnFileUPC { get; set; }

        //public bool? TaxInclusion { get; set; }

        //public decimal? LineItemTax { get; set; }

        //public string CommissPayID { get; set; }

        //public int? PromoNumb { get; set; }

        //public string PriceSource { get; set; }

        //public int? servcomm { get; set; }

        //public string PriceCode2 { get; set; }

        //public bool? ReqPrinted { get; set; }

        //public bool? GPReview { get; set; }

        //public bool? PrintComment { get; set; }

        //public bool? ReservedFlag { get; set; }

        //public DateTime? SOSaleDate { get; set; }

        //public short? SubClass { get; set; }

        //public byte? PackageClass { get; set; }

        //public short? Package { get; set; }

        //public string PackageSeq { get; set; }

        //public int? OrigTranNo { get; set; }

        //public short? OrigRegID { get; set; }

        //public string CopyFile { get; set; }

        //public short? CopyLineNo { get; set; }

        //public bool? AGChanges { get; set; }

        //public bool? ECDFlag { get; set; }

        //public string AisleNo { get; set; }

        //public string WarehouseNo { get; set; }
        #endregion
    }
}