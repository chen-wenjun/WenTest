using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class BayViewModel
    {
        public int? Id { get; set; }
        public string ZoneId { get; set; }
        public string ZoneDescription { get; set; }
        public string BayNumber { get; set; }
        public string LabelDirection { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}


