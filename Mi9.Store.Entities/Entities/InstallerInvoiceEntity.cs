using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The installer invoice entity.
    /// </summary>
    public class InstallerInvoiceEntity
    {
        public string InvoiceId { get; set; }

        public int InstallerId { get; set; }

        public DateTime? InvoiceDate { get; set; } // InvDate

        public DateTime? CreatedDate { get; set; } // CreateDate

        public string StatusCode { get; set; } // StatusCode Should be hardcoded to ‘G’ (Generated) when creating. Switched to  A when authorized.

        public decimal Tax { get; set; } // TaxAmount

        public decimal TotalInstaller { get; set; }

        public virtual InstallerEntity Installer { get; set; }

        public virtual ICollection<InstallationRequestEntity> Requests { get; set; }
    }
}