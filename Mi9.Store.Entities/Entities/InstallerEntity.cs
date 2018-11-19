using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The installer.
    /// </summary>
    public class InstallerEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the ranking.
        /// </summary>
        public decimal Ranking { get; set; }

        /// <summary>
        /// Gets or sets the number of positive feedback to the installer
        /// </summary>
        public int sol_positive { get; set; }

        /// <summary>
        /// Gets or sets the number of neutral feedback to the installer
        /// </summary>
        public int sol_neutro { get; set; }

        /// <summary>
        /// Gets or sets the number of negative feedback to the installer
        /// </summary>
        public int sol_negative { get; set; }

        /// <summary>
        /// Gets or sets the total installs.
        /// </summary>
        public int TotalInstalls { get; set; }

        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        [StringLength(1)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the tax exempt no.
        /// </summary>
        [StringLength(20)]
        public string TaxExemptNo { get; set; }

        /// <summary>
        /// Gets or sets the address line 1.
        /// </summary>
        public string Addr1 { get; set; }

        /// <summary>
        /// Gets or sets the address line 2.
        /// </summary>
        public string Addr2 { get; set; }

        /// <summary>
        /// Gets or sets the address line 3.
        /// </summary>
        public string Addr3 { get; set; }

        /// <summary>
        /// Gets or sets the address city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the install requests.
        /// </summary>
        public virtual ICollection<InstallationRequestEntity> InstallRequests { get; set; }

        /// <summary>
        /// Gets or sets the installer invoices.
        /// </summary>
        public virtual ICollection<InstallerInvoiceEntity> Invoices { get; set; }

        /// <summary>
        /// Gets or sets the installation alerts.
        /// </summary>
        public virtual ICollection<InstallationAlertEntity> InstallationAlerts { get; set; }

        /// <summary>
        /// Gets or sets the department classes.
        /// </summary>
        public virtual ICollection<DepartmentClassEntity> DepartmentClasses { get; set; } 
    }
}