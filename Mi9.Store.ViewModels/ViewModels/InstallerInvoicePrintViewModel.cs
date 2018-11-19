using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    
    public class InstallerInvoicePrintViewModel
    {
        public string InvoiceId { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public decimal TotalInstaller { get; set; } 

        public decimal Tax { get; set; }

        public decimal Total { get; set; }

        public InstallationRequestViewModel[] Requests { get; set; }

        public InstallerViewModelBase Installer { get; set; }

        public StoreViewModel CurrentStore { get; set; }
    }
}