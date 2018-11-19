using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class PrintingBatchHeaderEntity
    {
        public PrintingBatchHeaderEntity()
        {
            Details = new List<PrintingBatchDetailEntity>();
        }

        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public DateTime PrintingDate { get; set; }

        public virtual ICollection<PrintingBatchDetailEntity> Details { get; set; }
    }
}
