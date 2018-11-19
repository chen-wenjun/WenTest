using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
   
    public class ItemSkuEntity
    {
       
        private bool _isSpecialItem;

        private bool _isGenericItem;

        private bool _needPriceRecalcualate;

       
        public long Sku { get; set; }
        public long? SubSku { get; set; }
        public string Description { get; set; }
        public string SpecialItemType { get; set; }
        public string ItemType { get; set; }
        public decimal UOMConvert { get; set; }
        public string Type { get; set; }
        public decimal? Cost { get; set; }
        public decimal? RetailPrice { get; set; }
        public string AlphaKey { get; set; }
        public string StatusCode { get; set; }
        public DateTime? PromoStartDate { get; set; }
        public DateTime? PromoEndDate { get; set; }
        public TimeSpan? PromoStartTime { get; set; }
        public TimeSpan? PromoEndTime { get; set; }
        public decimal? PromoPrice { get; set; }
        public byte PromoType { get; set; }
        public decimal PromoDealPrice { get; set; }
        public byte PromoDealQty { get; set; }
        public decimal DealPrice { get; set; }
        public byte DealQty { get; set; }
        public short? DepatmentId { get; set; }
        public short? ClassId { get; set; }
        public short? SubClassId { get; set; }
        public string VendorId { get; set; }
        public byte? VendorSuffix { get; set; }
        public string VendPartNo { get; set; }
        public int? FeeId { get; set; }
        public string Uom { get; set; }
        public string TaxCode { get; set; }
        public string ProPricingType { get; set; }
        public virtual UnitOfMeasureEntity UnitOfMeasure { get; set; }
        public virtual FeeEntity Fee { get; set; }
        public virtual ItemReplenEntity ItemReplen { get; set; }
        public virtual DepartmentEntity Department { get; set; }
        public virtual DepartmentClassEntity DepartmentClass { get; set; }
        public virtual DepartmentSubClassEntity DepartmentSubClass { get; set; }
        public virtual VendorEntity Vendor { get; set; }
        public virtual TaxEntity Tax { get; set; }
        public virtual ICollection<PromotionItemEntity> Promotions { get; set; }
        public virtual ICollection<OrderItemEntity> OrderItems { get; set; }
        public ICollection<SccItemEntity> SccItems { get; set; }
        public ICollection<SccItemEntity> ProposalSccItems { get; set; }
        public virtual ICollection<BarCodeEntity> BarCodes { get; set; }
        public virtual SkuKitEntity KitHeader { get; set; }
        public ICollection<SkuRequestItemEntity> SkuRequestItems { get; set; }
        public virtual ICollection<ProPriceEntity> ProPrices { get; set; }
        public ICollection<PurchaseOrderItemEntity> PurchaseOrderItems { get; set; }
        public virtual ICollection<ItemVendorEntity> VendorItems { get; set; }
        public virtual ICollection<ResaleEntity> Resales { get; set; }
        public virtual ItemHistoryEntity ItemHistory { get; set; }
        public virtual ICollection<ShipmentItemEntity> ShipmentItems { get; set; }
        public virtual ICollection<ReturnToVendorItemEntity> ReturnToVendorItems { get; set; }
        public virtual ICollection<PalletItemEntity> PalletItems { get; set; }
        public ICollection<PackDownEntity> PackDowns { get; set; }

        
        public bool IsRegularItem
        {
            get
            {
                return !IsGenericItem && !IsSpecialItem;
            }
        }

        
        public bool IsGenericItem
        {
            get
            {
                return _isGenericItem;
            }

            set
            {
                _isGenericItem = value;
                if (_isGenericItem)
                {
                    NeedPriceRecalcualate = false;
                }
            }
        }

        
        public bool IsSpecialItem
        {
            get
            {
                return _isSpecialItem && (SpecialItemType == "S" || SpecialItemType == "L");
            }

            set
            {
                _isSpecialItem = value;
            }
        }

        
        public decimal Margin
        {
            get
            {
                if (!PriceWithoutTaxes.HasValue || !Cost.HasValue || PriceWithoutTaxes == 0)
                {
                    return 0;
                }

                return (decimal)((PriceWithoutTaxes - Cost) / PriceWithoutTaxes) * 100;
            }
        }

        public bool HasTaxes
        {
            get
            {
                return (Tax != null && Tax.TaxRate.HasValue);
            }
        }

        public decimal TaxAmount
        {
            get
            {
                return HasTaxes
                    ? Tax.IsTaxIncluded
                        ? Math.Round((RetailPrice * Tax.TaxRate.Value / (100 + Tax.TaxRate.Value)).Value, 2, MidpointRounding.AwayFromZero)
                        : Math.Round((RetailPrice * Tax.TaxRate.Value / 100).Value, 2, MidpointRounding.AwayFromZero)
                    : 0;
            }
        }

        public decimal? PriceWithoutTaxes
        {
            get
            {
                return HasTaxes
                    ? Tax.IsTaxIncluded
                        ? RetailPrice - TaxAmount
                        : RetailPrice
                    : RetailPrice;
            }

        }

        
        public decimal MarginAbs
        {
            get
            {
                if (!PriceWithoutTaxes.HasValue || !Cost.HasValue || PriceWithoutTaxes == 0)
                {
                    return 0;
                }

                return (decimal)(PriceWithoutTaxes - Cost);
            }
        }

       
        public bool NeedPriceRecalcualate
        {
            get
            {
                return IsGenericItem ? false : _needPriceRecalcualate;
            }

            set
            {
                _needPriceRecalcualate = value;
            }
        }
        public string XMerchLoc1 { get; set; }
        public string XMerchLoc2 { get; set; }
        public string XMerchLoc3 { get; set; }
        public string XMerchLoc4 { get; set; }
        public string XMerchLoc5 { get; set; }
        public string XMerchLoc6 { get; set; }
        public string XMerchLoc7 { get; set; }
        public string XMerchLoc8 { get; set; }
    }
}
