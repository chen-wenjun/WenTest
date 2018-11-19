using System.Collections.Generic;
using System.Linq;
using Mi9.Store.Localization;
using Mi9.Store.ViewModels.ViewModels.Enums;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class AccountReceivableOrderViewModel : OrderViewModel
    {
        public AccountReceivableOrderViewModel()
        {
            OrderType = new AccountReceivable();
            Customer = new RequiredCustomerViewModel();
        }

        protected override List<OrderTypeBaseViewModel> GetAvailableTypes()
        {
            var availableTypes = new List<OrderTypeBaseViewModel> { new AccountReceivable() };
            var onlyArCustomer = Customer.CustomerType == CustomerTypes.ProWithAr;
            var onlyNotSpecialOrderItems = Items.Where(t => t.ItemSku.ItemType == "SKU").All(t => t.ItemSku.SpecialItemType == "normal");
            var notExeedsAvailableCredit = Items.Sum(t => t.ExtendedAmount) <= Customer.AvailableCredit;
            if (!onlyArCustomer)
            {
                availableTypes[0].WarningMessages.Add(Strings.OnlyForARCustomerMessage);
            }

            if (!onlyNotSpecialOrderItems)
            {
                availableTypes[0].WarningMessages.Add(Strings.AllSkuMustBeNormalMessage);
            }

            if (!notExeedsAvailableCredit)
            {
                availableTypes[0].WarningMessages.Add(Strings.ExceedsAvailableCreditMessage);
            }

            if (!onlyNotSpecialOrderItems && onlyArCustomer)
            {
                availableTypes.Add(new AccountReceivableSpecialDeposit());
            }

            return availableTypes;
        }
    }
}