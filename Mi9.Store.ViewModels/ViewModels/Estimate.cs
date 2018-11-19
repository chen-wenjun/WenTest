using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class Estimate : OrderTypeBaseViewModel, IRegularOrderType, IProOrderType
    {
        public Estimate()
        {
            StoreOrderType = "Estimation";
        }

        public override List<OrderTypeBaseViewModel> GetAvailiableTypes()
        {
            return new List<OrderTypeBaseViewModel> { new Estimate(), new Regular(), new CashOnDelivery(), new LayawayDeposit(), new SpecialDeposit(), new AccountReceivable(), new AccountReceivableSpecialDeposit() };
        }
    }
}