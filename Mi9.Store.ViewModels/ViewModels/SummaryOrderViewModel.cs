using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SummaryOrderViewModel
    {
        private decimal _depositDue;

        private decimal _refundDue;

        [JsonProperty(PropertyName = "feesAndServices")]
        public decimal FeesAndServicesPriceTotal { get; set; }

        [JsonProperty(PropertyName = "salesTax")]
        public decimal SalesTax { get; set; }

        public decimal SpecialSalesTax { get; set; }

        [JsonProperty(PropertyName = "orderTotal")]
        public decimal OrderTotal
        {
            get
            {
                return SkuExtendedPriceTotal + FeesAndServicesPriceTotal + SalesTax;
            }
        }

        public decimal SkuExtendedPriceTotal { get; set; }

        public decimal SpecialSkuExtendedPriceTotal { get; set; }

        [JsonProperty(PropertyName = "layawayPercent")]
        public decimal LayawayPercent { get; set; }

        [JsonProperty(PropertyName = "quantityTotal")]
        public decimal QuantityTotal { get; set; }

        [JsonProperty(PropertyName = "extendedPriceTotal")]
        public decimal ExtendedPriceTotal
        {
            get
            {
                return SkuExtendedPriceTotal;
            }
        }

        [JsonProperty(PropertyName = "specialExtendedPriceTotal")]
        public decimal SpecialExtendedPriceTotal
        {
            get
            {
                return SpecialSkuExtendedPriceTotal + SpecialSalesTax;
            }
        }

        [JsonProperty(PropertyName = "isRefundSummary")]
        public bool IsRefundSummary { get; set; }

        [JsonProperty(PropertyName = "depositDue")]
        public decimal DepositDue { get; set; }

        [JsonProperty(PropertyName = "refundDue")]
        public decimal RefundDue
        {
            get
            {
                return _refundDue;
            }

            set
            {
                if (value > 0)
                {
                    throw new ArgumentOutOfRangeException("RefundDue must be less or equal then zero");
                }

                _refundDue = value;
            }
        }

        [JsonProperty(PropertyName = "totalPaid")]
        public decimal TotalPaid { get; set; }

        [JsonProperty(PropertyName = "totalRefunded")]
        public decimal TotalRefunded { get; set; }

        [JsonProperty(PropertyName = "balanceDue")]
        public decimal BalanceDue
        {
            get
            {
                //return OrderTotal + DepositDue;
                return OrderTotal - TotalPaid;
            }
        }

        [JsonProperty(PropertyName = "amountRetained")]
        public decimal AmountRetained
        {
            get
            {
                return TotalPaid + RefundDue;
            }
        }

        [JsonProperty(PropertyName = "availableCredit")]
        public decimal AvailableCredit { get; set; }

        [JsonProperty(PropertyName = "specialOrderPercent")]
        public decimal SpecialOrderPercent { get; set; }

        [JsonProperty(PropertyName = "aRSpecialOrderPercent")]
        public decimal ARSpecialOrderPercent { get; set; }

        [JsonProperty(PropertyName = "feesAndServicesPriceTax")]
        public decimal FeesAndServicesPriceTax { get; set; }

        [JsonProperty(PropertyName = "extendedPrices")]
        public Dictionary<int, decimal> ExtendedPrices { get; set; }

        [JsonProperty(PropertyName = "extendedTaxes")]
        public Dictionary<int, decimal> ExtendedTaxes { get; set; }
    }
}