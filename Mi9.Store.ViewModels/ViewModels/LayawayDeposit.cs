using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LayawayDeposit : OrderTypeBaseViewModel, IDepositOrderType, INotSpecialOrderType
    {
        public LayawayDeposit()
        {
            StoreOrderType = "Layaway_Deposit";
        }

        public override List<OrderTypeBaseViewModel> GetAvailiableTypes()
        {
            return new List<OrderTypeBaseViewModel> { new LayawayDeposit(), new LayawayPickup() };
        }
    }
}