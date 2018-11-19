using System;
using System.ComponentModel.DataAnnotations;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The installation alert entity.
    /// </summary>
    public class InstallationAlertEntity
    {
        /// <summary>
        /// Gets or sets the service id.
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// Gets or sets the service pack id.
        /// </summary>
        public int AutoSequence { get; set; }

        /// <summary>
        /// Gets or sets the service sequence.
        /// </summary>
        public int? InstallerId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public int AlertId { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets a the alert type. 
        /// </summary>
        [StringLength(20)]
        public string AlertType { get; set; }

        /// <summary>
        /// Gets or sets a the status code. 
        /// </summary>
        [StringLength(1)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the escalation level.
        /// </summary>
        public byte EscalationLevel { get; set; }

        /// <summary>
        /// Gets or sets the order number.
        /// </summary>
        public int OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the installer.
        /// </summary>
        public virtual InstallerEntity Installer { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        public virtual OrderEntity Order { get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        public virtual InstallationRequestEntity InstallationRequest { get; set; } 
    }
}