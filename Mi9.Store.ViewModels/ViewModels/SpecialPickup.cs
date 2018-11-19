using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SpecialPickup : OrderTypeBaseViewModel, IPickupOrderType, ISpecialOrderType, IRegularOrderType, IProOrderType
    {
        public SpecialPickup()
        {
            StoreOrderType = "Complete_Special_Order_Pickup";
        }

        public override List<OrderTypeBaseViewModel> GetAvailiableTypes()
        {
            return new List<OrderTypeBaseViewModel> { new SpecialPickup() };
        }
    }
}