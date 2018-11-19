namespace Mi9.Store.Entities.Entities
{
    public class InstallationWarrantyIssuePostEntity
    {
        public int WarrantyTypeId { get; set; }

        public int WarrantyChargeKindId { get; set; }

        public int OriginalRequestId { get; set; }
        
        public Service[] Services { get; set; }

        public class Service
        {
            /// <summary>
            /// Gets or sets the service id.
            /// </summary>
            public int ServiceId { get; set; }

            /// <summary>
            /// Gets or sets the installation pack id.
            /// </summary>
            public int InstallationPackId { get; set; }

            /// <summary>
            /// Gets or sets the service sequence.
            /// </summary>
            public short ServiceSequence { get; set; }

            /// <summary>
            /// Gets or sets the cost.
            /// </summary>
            public decimal InstCost { get; set; }

            /// <summary>
            /// Gets or sets the price.
            /// </summary>
            public decimal InstPrice { get; set; }

            /// <summary>
            /// Gets or sets the quantity.
            /// </summary>
            public int Quantity { get; set; }

            /// <summary>
            /// Gets or sets the price.
            /// </summary>
            public decimal Charge { get; set; }
        }
    }
}