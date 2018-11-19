using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class AccountReceivableSpecialDeposit : OrderTypeBaseViewModel, ISpecialOrderType, IProOrderType
    {
        public AccountReceivableSpecialDeposit()
        {
            StoreOrderType = "AR_Special_Order_Deposit";
        }

        public override List<OrderTypeBaseViewModel> GetAvailiableTypes()
        {
            return new List<OrderTypeBaseViewModel> { new AccountReceivableSpecialDeposit(), new AccountReceivableSpecialPickup() };
        }
    }
}