using System;

namespace Mi9.Store.Entities.Entities
{
    public class CashierBalanceEntity
    {
        public int EmployeeNo { get; set; }
        public DateTime Date { get; set; }
        public bool Approved { get; set; }
        public string Comment { get; set; }
    }
}
