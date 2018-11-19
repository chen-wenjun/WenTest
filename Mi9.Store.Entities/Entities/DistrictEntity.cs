// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DistrictEntity.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   Defines the DistrictEntity type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class DistrictEntity
    {
        public string DistrictCode { get; set; }

        public string DistrictName { get; set; }

        public virtual ICollection<StoreEntity> Stores { get; set; } 
    }
}
