using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class OrderTypeBaseViewModel
    {
        public OrderTypeBaseViewModel()
        {
            WarningMessages = new List<string>();
        }

        public int Id { get; set; }

        public string StoreOrderType { get; set; }

        public string StoreOrderTypeName { get; set; }

        public string OrderType { get; set; }

        public byte? SaleType { get; set; }

        public List<string> WarningMessages { get; set; }

        public string ConfirmationMessage { get; set; }

        public virtual List<OrderTypeBaseViewModel> GetAvailiableTypes()
        {
            return new List<OrderTypeBaseViewModel>();
        }
    }
}