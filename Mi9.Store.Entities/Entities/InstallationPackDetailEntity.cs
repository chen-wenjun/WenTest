using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The installation pack detail (INstServDet table).
    /// </summary>
    public class InstallationPackDetailEntity
    {
        /// <summary>
        /// Gets or sets the service id.
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the service pack id.
        /// </summary>
        public int InstallationPackId { get; set; }

        /// <summary>
        /// Gets or sets the service sequence.
        /// </summary>
        public short ServiceSequence { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the installation cost.
        /// </summary>
        public decimal InstCost { get; set; }

        /// <summary>
        /// Gets or sets the installation price.
        /// </summary>
        public decimal InstPrice { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates 
        /// if this is a service or only a comment to a service.
        /// </summary>
        [StringLength(1)]
        public string ServiceOrComment { get; set; }

        /// <summary>
        /// Gets or sets the servcomm. The servcomm is the reference to the ServHdrId(InstallationPackId) which is make a reference.
        /// </summary>
        public int servcomm { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets whether or not this is an Installation Pack/Technical Visit/Warranty
        /// (use values I/V/G)
        /// </summary>
        [StringLength(1)]
        public string TypeServ { get; set; }

        /// <summary>
        /// Gets or sets the code of the unit of measure.
        /// </summary>
        public string Uom { get; set; }

        /// <summary>
        /// Gets or sets the description of the unit of measure.
        /// </summary>
        public string UOMDescription { get; set; }

        [StringLength(1)]
        public string StatusCode { get; set; }

        public DateTime? StatusDate { get; set; }

        /// <summary>
        /// Gets or sets the service pack entity.
        /// </summary>
        public virtual InstallationPackEntity InstallationPack { get; set; }

        /// <summary>
        /// Gets or sets the request details.
        /// </summary>
        public virtual ICollection<InstallationRequestDetailEntity> RequestDetails { get; set; }

        /// <summary>
        /// Gets or sets the order items.
        /// </summary>
        public virtual ICollection<OrderItemEntity> OrderItems { get; set; } 
    }
}
