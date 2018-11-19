using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CustomerOrderHistoryViewModel
    {
        public DateTime SinceDate { get; set; }

        public decimal SinceAmount { get; set; }

        public DateTime LastPurchaseDate { get; set; }

        public decimal LastPurchaseAmount { get; set; }
    }
}