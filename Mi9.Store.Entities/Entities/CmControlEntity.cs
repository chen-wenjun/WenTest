namespace Mi9.Store.Entities.Entities
{
    public class CmControlEntity
    {
        public int Id { get; set; }

        public decimal StartBankAmount { get; set; }

        public decimal MaxCashDrawer { get; set; }

        public string BalancingMethod { get; set; }

        public bool BlindBalance { get; set; }

        public bool AutoDepNumber { get; set; } 
    }
}
