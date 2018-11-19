// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailEntity.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   The Email type entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The email type entity.
    /// </summary>
    [Table("Email")]
    public class EmailEntity
    {
        /// <summary>
        /// Gets or sets the function type.
        /// </summary>
        [Key, Column(Order = 0), StringLength(15)]
        public string FunctionType { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        [Key, Column(Order = 1)]
        public byte Level { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the from address.
        /// </summary>
        [StringLength(254)]
        public string FromAddress { get; set; }

        /// <summary>
        /// Gets or sets the to address.
        /// </summary>
        public string ToAddress { get; set; }

        /// <summary>
        /// Gets or sets the carbon copy address.
        /// </summary>
        [Column("CCAddress")]
        public string CarbonCopyAddress { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        [StringLength(255)]
        public string Subject { get; set; }
    }
}
