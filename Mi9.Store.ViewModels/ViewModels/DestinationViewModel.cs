// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DestinationViewModel.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   Defines the DestinationViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class DestinationViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public string StoreNumber { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string StoreName { get; set; }

        [JsonProperty(PropertyName = "district")]
        public string District { get; set; }

        [JsonProperty(PropertyName = "authorized")]
        public bool PermAuth { get; set; }

        [JsonProperty(PropertyName = "dateFrom")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? AuthStartDate { get; set; }

        [JsonProperty(PropertyName = "dateTo")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? AuthExpiredDate { get; set; }

        [JsonProperty(PropertyName = "nearby")]
        public bool Nearby { get; set; }

        [JsonProperty(PropertyName = "sameDistrict")]
        public bool InDistrict { get; set; }

        [JsonProperty(PropertyName = "sourceStore")]
        public StoreViewModel SourceStore { get; set; }
        
    }
}