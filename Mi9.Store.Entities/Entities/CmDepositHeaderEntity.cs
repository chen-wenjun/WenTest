using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class CmDepositHeaderEntity
    {
        public CmDepositHeaderEntity()
        {
            Tenders = new List<CmDepositDetailEntity>();
        }

        public long DepositNumber { get; set; }

        public int EmployeeNo { get; set; }

        public DateTime? DepositDate { get; set; }

        public string ReferenceNumber { get; set; }

        public DateTime? UploadedDate { get; set; }

        public virtual ICollection<CmDepositDetailEntity> Tenders { get; set; }
    }
}
