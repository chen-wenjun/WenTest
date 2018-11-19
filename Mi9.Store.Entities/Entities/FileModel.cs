// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileModel.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   The file model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.IO;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The file model.
    /// </summary>
    public class FileModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the edit date.
        /// </summary>
        public DateTime EditDate { get; set; }

        /// <summary>
        /// Gets or sets the purchase order number.
        /// </summary>
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public Stream Content { get; set; }
    }
}
