
using System.Collections.Generic;
using System.Linq;
using Mi9.Store.Localization;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RegularOrderViewModel : OrderViewModel
    {
        public RegularOrderViewModel()
        {
            OrderType = new Regular();
            Customer = new RequiredCustomerViewModel();
        }

        protected override List<OrderTypeBaseViewModel> GetAvailableTypes()
        {
            var availableTypes = new List<OrderTypeBaseViewModel> { new Regular() };
            var onlyNotSpecialOrderItems = Items.Where(t => t.ItemSku.ItemType == "SKU").All(t => t.ItemSku.SpecialItemType == "normal");
            if (onlyNotSpecialOrderItems)
            {
                var availableCutomerTypes = Customer.CustomerType != CustomerTypes.ProWithAr
                                             || (Customer.CustomerType == CustomerTypes.ProWithAr && Customer.AvailableCredits == "Cash");
                //if (availableCutomerTypes)
                //{
                //    //if (Items.Where(t => t.ItemSku.ItemType == "SKU").Any(t => t.DeliveryMethod == "Delivery") && Customer.IsGeneric)
                    //{
                        //bool needNotGenericName = !string.IsNullOrWhiteSpace(Customer.FirstName)
                        //                          && Customer.FirstName != "Generic"
                        //                          && Customer.FirstName != "CLIENTE EFECTIVO";
                        //if (!needNotGenericName)
                        //{
                        //    availableTypes[0].WarningMessages.Add(Strings.GenericMustHaveNameMessage);
                        //}
                    //}
                //}
                //else
                //{
                    if (!availableCutomerTypes)
                        availableTypes[0].WarningMessages.Add(Strings.OrderTypeNotForARCustomerMessage);
                //}
            }
            else
            {
                availableTypes[0].WarningMessages.Add(Strings.AllSkuMustBeNormalMessage);
                availableTypes.Add(new SpecialDeposit());
            }

            return availableTypes;
        }
    }
}