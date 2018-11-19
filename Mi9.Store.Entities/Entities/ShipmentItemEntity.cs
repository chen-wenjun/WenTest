// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShipmentItemEntity.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   Defines the ShipmentDetail type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Mi9.Store.Entities.Entities
{
    public class ShipmentItemEntity
    {
        public string ShipmentNumber { get; set; }

        public long SKU { get; set; }

        public decimal Quantity { get; set; }

        public decimal ReceivedQuantity { get; set; }

        public decimal DamagedQuantity { get; set; }

        public DateTime? LastDateReceived { get; set; }

        public virtual ShipmentEntity Shipment { get; set; }

        public virtual ItemSkuEntity ItemSku { get; set; }
    }
}
