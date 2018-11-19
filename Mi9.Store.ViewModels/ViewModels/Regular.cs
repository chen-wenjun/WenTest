using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class Regular : OrderTypeBaseViewModel, INotSpecialOrderType, IRegularOrderType, IProOrderType
    {
        public Regular()
        {
            StoreOrderType = "Order";
        }

        public override List<OrderTypeBaseViewModel> GetAvailiableTypes()
        {
            return new List<OrderTypeBaseViewModel> { new Regular() };
        }
    }
}