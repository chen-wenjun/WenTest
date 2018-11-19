using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The order definition entity.
    /// </summary>
    public class OrderDefinitionEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the store order type.
        /// </summary>
        public string StoreOrderType { get; set; }

        /// <summary>
        /// Gets or sets the store order type name.
        /// </summary>
        public string StoreOrderTypeName { get; set; }

        /// <summary>
        /// Gets or sets the order type.
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// Gets or sets the sale type.
        /// </summary>
        public byte? SaleType { get; set; }

        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        public ICollection<OrderEntity> Orders { get; set; }
    }
}