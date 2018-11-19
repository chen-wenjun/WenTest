
using System;
using System.IO;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class FileViewModel
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime EditDate { get; set; }

        public Stream Content { get; set; }

        public string PurchaseOrderNumber { get; set; }
    }
}
