using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class RegularCustomerListViewModel
    {
        public RegularCustomerListViewModel()
        {
            Customers = new List<CustomerViewModel>();
        }

        public List<CustomerViewModel> Customers { get; set; }
    }
}