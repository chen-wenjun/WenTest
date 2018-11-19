using System;
using System.Collections.Generic;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class WithdrawalPrintViewModel
    {
        public WithdrawalPrintViewModel()
        {
            WithdrawalDenominations = new List<WithdrawalDenominationPrintView>();
        }

        [JsonProperty(PropertyName = "originalHeader")]
        public List<string> OriginalHeader { get; set; }

        [JsonProperty(PropertyName = "copyHeader")]
        public List<string> CopyHeader { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int WithdrawalId { get; set; }

        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime WithdrawalDate { get; set; }

        [JsonProperty(PropertyName = "seq")]
        public short? PartialNumber { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string DocumentType { get; set; }

        [JsonProperty(PropertyName = "cashier")]
        public CashierViewModel Cashier { get; set; }

        [JsonProperty(PropertyName = "tenderTypes")]
        public List<WithdrawalDenominationPrintView> WithdrawalDenominations { get; set; }

        public bool ShouldSerializePartialNumber()
        {
            return PartialNumber.HasValue;
        }

        public class CashierViewModel
        {
            [JsonProperty(PropertyName = "id")]
            public int CashierId { get; set; }

            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }
        }

        public class WithdrawalDenominationPrintView
        {
            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "displayOrder")]
            public int DisplayOrder { get; set; }

            [JsonProperty(PropertyName = "quantity")]
            public decimal Quantity { get; set; }

            [JsonProperty(PropertyName = "totalPrice")]
            public decimal TotalPrice { get; set; }

            [JsonProperty(PropertyName = "tenderType")]
            public TenderTypePrintView TenderType { get; set; }

            [JsonProperty(PropertyName = "tender")]
            public TenderPrintView Tender { get; set; }

            public class TenderTypePrintView
            {
                [JsonProperty(PropertyName = "tenderCode")]
                public byte TenderCode { get; set; }

                [JsonProperty(PropertyName = "description")]
                public string Description { get; set; }
            }

            public class TenderPrintView
            {
                [JsonProperty(PropertyName = "tenderId")]
                public int TenderId { get; set; }

                [JsonProperty(PropertyName = "key")]
                public string Key { get; set; }
            }
        }
    }
}