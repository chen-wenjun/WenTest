using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class AccountReceivable : OrderTypeBaseViewModel, INotSpecialOrderType, IProOrderType
    {
        public AccountReceivable()
        {
            StoreOrderType = "AR_Order";
        }

        public override List<OrderTypeBaseViewModel> GetAvailiableTypes()
        {
            return new List<OrderTypeBaseViewModel> { new AccountReceivable() };
        }
    }
}
