using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The installation request.
    /// </summary>
    public class InstallationRequestEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the install pack id.
        /// </summary>
        public int PackId { get; set; }

        /// <summary>
        /// Gets or sets the order no.
        /// </summary>
        public int OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the order no vt.
        /// </summary>
        public int orderNoVT { get; set; }

        /// <summary>
        /// Gets or sets the order no vt.
        /// </summary>
        public int OrderNoMat { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the prognosis date start (of installation).
        /// </summary>
        public DateTime? ProgDateStart { get; set; }

        /// <summary>
        /// Gets or sets the prognosis date end (of installation).
        /// </summary>
        public DateTime? ProgDateEnd { get; set; }

        /// <summary>
        /// Gets or sets the whished date.
        /// </summary>
        public DateTime? WishedDate { get; set; }

        /// <summary>
        /// Gets or sets the feasible date.
        /// </summary>
        public DateTime? FeasibleDate { get; set; }

        /// <summary>
        /// Gets or sets the invoice date.
        /// </summary>
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// Gets or sets the invoice id.
        /// </summary>
        [StringLength(16)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Gets or sets the transaction date.
        /// </summary>
        public DateTime? TranDate { get; set; }

        /// <summary>
        /// Gets or sets the register id.
        /// </summary>
        public short RegisterId { get; set; }

        /// <summary>
        /// Gets or sets the transaction number.
        /// </summary>
        public int TranNumber { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the regular installation price.
        /// </summary>
        public decimal InstallationPrice { get; set; }

        /// <summary>
        /// Gets or sets the installation cost.
        /// </summary>
        public decimal? InstallationCost { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Gets or sets the tax amount.
        /// </summary>
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        [StringLength(1)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the status code before request was suspended.
        /// </summary>
        [StringLength(1)]
        public string SuspendPreviosStatus { get; set; }

        /// <summary>
        /// Gets or sets the install type.
        /// </summary>
        [StringLength(1)]
        public string InstallType { get; set; }

        /// <summary>
        /// Gets or sets the installer id.
        /// </summary>
        public int? InstallerId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the reason of suspend.
        /// </summary>
        public string ReasonOfSuspend { get; set; }

        /// <summary>
        /// Gets or sets the customer no.
        /// </summary>
        public long CustomerNo { get; set; }

        /// <summary>
        /// Gets or sets the customer sub key.
        /// </summary>
        public short CustomerSubKey { get; set; }

        /// <summary>
        /// Gets or sets Order No, to which current technical visit is claimed as a credit.
        /// </summary>
        public int ProcSolic { get; set; }

        /// <summary>
        /// Gets or sets comments.
        /// </summary>
        [StringLength(1000)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets customer feedback.
        /// </summary>
        [StringLength(1)]
        public string FeedbackId { get; set; }

        /// <summary>
        /// Gets or sets guarantee fee source.
        /// </summary>
        [StringLength(10)]
        public string GuaranteeFeeSource { get; set; }

        /// <summary>
        /// Gets or sets the installer reassign reason.
        /// </summary>
        [StringLength(100)]
        public string InstallerReassignReason { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        public virtual OrderEntity Order { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        public virtual CustomerEntity Customer { get; set; }

        /// <summary>
        /// Gets or sets the installer.
        /// </summary>
        public virtual InstallerEntity Installer { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public virtual ICollection<InstallationRequestDetailEntity> Details { get; set; }

        /// <summary>
        /// Gets or sets the installation alerts.
        /// </summary>
        public virtual ICollection<InstallationAlertEntity> InstallationAlerts { get; set; }
        
        /// <summary>
        /// Gets or sets the service.
        /// </summary>
        public virtual InstallationPackEntity InstallationPack { get; set; }

        /// <summary>
        /// Gets or sets the invoice.
        /// </summary>
        public virtual InstallerInvoiceEntity Invoice { get; set; }
    }
}
