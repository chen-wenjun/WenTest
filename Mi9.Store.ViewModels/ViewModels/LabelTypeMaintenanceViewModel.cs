using System.Collections.Generic;
using Mi9.Store.Entities.Entities;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LabelTypeMaintenanceViewModel
    {
        public IEnumerable<PrinterEntity> Printers { get; set; }

        public IEnumerable<LabelTypeRelationshipViewModel> LabelTypeRelationships { get; set; }
    }
}
