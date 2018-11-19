using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    
    public class AccountReceivableSpecialPickup : OrderTypeBaseViewModel, IPickupOrderType, ISpecialOrderType, IProOrderType
    {
        public AccountReceivableSpecialPickup()
        {
            StoreOrderType = "Complete_AR_Special_Order_Pickup";
        }

        public override List<OrderTypeBaseViewModel> GetAvailiableTypes()
        {
            return new List<OrderTypeBaseViewModel> { new AccountReceivableSpecialPickup() };
        }
    }
}