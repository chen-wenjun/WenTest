using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class HoleSKUViewModel
    {
        public long? Id { get; set; }

        public long SKU { get; set; }

        public string ZoneId { get; set; }

        public string Bays { get; set; }

        public DateTime CreateDate { get; set; }

        public string StatusCode { get; set; }

        public DateTime StatusDate { get; set; }

        public int EmployeeNo { get; set; }

        public TimeSpan MntTime { get; set; }

        public string typeHole { get; set; }

        public DateTime? StatusDateClose { get; set; }

        public int? EmployeeNoClose { get; set; }

        public TimeSpan? TimeClose { get; set; }

        public string ZoneIdOver { get; set; }

        public int? BaysOver { get; set; }

        public string TypePdn { get; set; }

    }
}
