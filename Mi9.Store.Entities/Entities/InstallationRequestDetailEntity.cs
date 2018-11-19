namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The installation request detail.
    /// </summary>
    public class InstallationRequestDetailEntity
    {
        /// <summary>
        /// Gets or sets the request id.
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// Gets or sets the request sequence.
        /// </summary>
        public short RequestSequence { get; set; }

        /// <summary>
        /// Gets or sets the installation pack id.
        /// </summary>
        public int PackId { get; set; }

        /// <summary>
        /// Gets or sets the service sequence.
        /// </summary>
        public short PackServiceSequence { get; set; }

        /// <summary>
        /// Gets or sets the service id.
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        public virtual InstallationRequestEntity Request { get; set; }

        /// <summary>
        /// Gets or sets the service details.
        /// </summary>
        public virtual InstallationPackDetailEntity InstallationPackDetail { get; set; }
    }
}