using System;
using System.Collections.Generic;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    
    [JsonObject(MemberSerialization.OptIn)]
    public class SccItemViewModel
    {
        public SccItemViewModel()
        {
            ItemStatus = SccItemStatus.New;
        }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "followUpDate")]
        //[JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? FollowUpDate { get; set; }

        [JsonProperty(PropertyName = "quantityRequired")]
        public decimal QuantityRequired { get; set; }

        [JsonProperty(PropertyName = "quantitySold")]
        public decimal QuantitySold { get; set; }

        [JsonProperty(PropertyName = "targetPrice")]
        public decimal TargetPrice { get; set; }

        [JsonProperty(PropertyName = "proPrice")]
        public decimal? ProPrice { get; set; }

        [JsonProperty(PropertyName = "extendedPrice")]
        public decimal ExtendedPrice { get; set; }

        [JsonProperty(PropertyName = "itemStatus")]
        public string ItemStatus { get; set; }

        [JsonProperty(PropertyName = "itemStatusTitle")]
        public string ItemStatusTitle 
        {
            get { return SccItemStatus.Dict.ContainsKey(ItemStatus) ? SccItemStatus.Dict[ItemStatus] : SccItemStatus.Dict[SccItemStatus.Unknown]; }
        }

        [JsonProperty(PropertyName = "itemRemarks")]
        public string ItemRemarks { get; set; }

        [JsonProperty(PropertyName = "storeRemarks")]
        public string StoreRemarks { get; set; }

        [JsonProperty(PropertyName = "skuId")]
        public long SkuId { get; set; }

        [JsonProperty(PropertyName = "proposalSkuId")]
        public long? ProposalSkuId { get; set; }

        [JsonProperty(PropertyName = "item")]
        // ReSharper disable once InconsistentNaming
        public ItemSkuViewModel ItemSKU { get; set; }

        [JsonProperty(PropertyName = "proposalItem")]
        // ReSharper disable once InconsistentNaming
        public ItemSkuViewModel ProposalItemSKU { get; set; }

        [JsonProperty(PropertyName = "agreementId")]
        public int AgreementId { get; set; }

        [JsonProperty(PropertyName = "competitors")]
        public List<SccItemCompetitorViewModel> Competitors { get; set; }

        [JsonProperty(PropertyName = "supportDescription")]
        public string SupportDescription { get; set; }

    }
}