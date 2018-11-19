// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeeEntity.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   The fee entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The fee entity.
    /// </summary>
    public class FeeEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the fee type.
        /// </summary>
        public string FeeType { get; set; }

        /// <summary>
        /// Gets or sets the fee amount.
        /// </summary>
        public decimal FeeAmount { get; set; }

        /// <summary>
        /// Gets or sets the min price.
        /// </summary>
        public decimal MinPrice { get; set; }

        /// <summary>
        /// Gets or sets the max price.
        /// </summary>
        public decimal MaxPrice { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the tax code.
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// Gets or sets the begin date.
        /// </summary>
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTime? EndingDate { get; set; }

        /// <summary>
        /// Gets or sets the tax.
        /// </summary>
        public virtual TaxEntity Tax { get; set; }

        /// <summary>
        /// Gets or sets the item sku entities.
        /// </summary>
        public virtual ICollection<ItemSkuEntity> ItemSkuEntities { get; set; }

        /// <summary>
        /// Gets or sets the order items.
        /// </summary>
        public virtual ICollection<OrderItemEntity> OrderItems { get; set; } 
    }
}

