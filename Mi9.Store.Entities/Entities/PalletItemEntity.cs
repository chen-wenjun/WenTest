// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalletItemEntity.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   The pallet item entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Mi9.Store.Entities.Entities
{
    public class PalletItemEntity
    {
        public string PalletId { get; set; }

        public long SKU { get; set; }

        public string VelocityCode { get; set; }

        public string Remarks { get; set; }

        public decimal Quantity { get; set; }

        public decimal QtyReceived { get; set; }

        public decimal QtyDamaged { get; set; }

        public DateTime? LastDateReceived { get; set; }

        public string MasterLabel { get; set; }

        public string Comments { get; set; }

        public virtual PalletEntity Pallet { get; set; }

        public virtual ItemSkuEntity SkuItem { get; set; }
    }
}
       
