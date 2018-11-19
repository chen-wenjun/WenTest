using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SpecialDeposit : OrderTypeBaseViewModel, IDepositOrderType, ISpecialOrderType, IProOrderType
    {
        public SpecialDeposit()
        {
            StoreOrderType = "Special_Order_Deposit";
        }

        public override List<OrderTypeBaseViewModel> GetAvailiableTypes()
        {
            return new List<OrderTypeBaseViewModel> { new SpecialDeposit(), new SpecialPickup() };
        }
    }
}