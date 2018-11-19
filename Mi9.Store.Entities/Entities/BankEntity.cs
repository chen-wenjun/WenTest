using System;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// Represents a bank entity.
    /// </summary>
    public class BankEntity
    {
        public string BankCode { get; set; }

        public int BankId { get; set; }

        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? LastUpdate { get; set; }

        public DateTime? InactiveDate { get; set; }

        public string CreateUser { get; set; }

        public string LastUpdateUser { get; set; }

        public string InactiveUser { get; set; }

        public bool IsActive { get; set; }

        public string BankName { get; set; }
    }
}
