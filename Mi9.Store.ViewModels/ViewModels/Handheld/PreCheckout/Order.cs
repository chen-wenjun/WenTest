// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Order.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   Defines the Order type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Mi9.Store.ViewModels.ViewModels;

namespace MI9.HDM.Store.BackOffice.ViewModelService.ViewModels.Handheld.PreCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the order number.
        /// </summary>
        [JsonProperty(PropertyName = "OrderNumber")]
        public int OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the card scan code.
        /// </summary>
        [JsonProperty(PropertyName = "CardScanCode")]
        public string PreCheckoutCardNumber { get; set; }

        /// <summary>
        /// Gets or sets the order items.
        /// </summary>
        [JsonProperty(PropertyName = "OrderItems")]
        public List<OrderItem> Items { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        public CustomerViewModel Customer { get; set; }

        /// <summary>
        /// Gets or sets the payrollId.
        /// </summary>
        public string PayrollId { get; set; }
    }
}
