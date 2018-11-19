using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CashOnDelivery : OrderTypeBaseViewModel, INotSpecialOrderType, IRegularOrderType, IProOrderType
    {
        public CashOnDelivery()
        {
            StoreOrderType = "COD";
        }

        public override List<OrderTypeBaseViewModel> GetAvailiableTypes()
        {
            return new List<OrderTypeBaseViewModel> { new CashOnDelivery() };
        }
    }
}