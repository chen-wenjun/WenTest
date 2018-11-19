using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LayawayPickup : OrderTypeBaseViewModel, IPickupOrderType, IRegularOrderType
    {
        public LayawayPickup()
        {
            StoreOrderType = "Layaway_Pickup";
        }

        public override List<OrderTypeBaseViewModel> GetAvailiableTypes()
        {
            return new List<OrderTypeBaseViewModel> { new LayawayPickup() };
        }
    }
}