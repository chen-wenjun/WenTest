using System;
using System.Collections.Generic;
using System.Linq;
using Mi9.Store.Localization;
using Mi9.Store.ViewModels.ViewModels.Enums;

namespace Mi9.Store.ViewModels.ViewModels
{
    public sealed class LayawayOrderViewModel : OrderViewModel, IAdvanceCancellationOrder
    {
        public LayawayOrderViewModel()
        {
            OrderType = new LayawayDeposit();
            Customer = new RequiredCustomerViewModel();
        }

        public override string OrderStatus
        {
            get
            {
                if (Items.Where(t => t.ItemSku != null && t.ItemSku.ItemType == "SKU").All(t => t.DeliveryMethod == "Pick" || t.DeliveryMethod == "Take" || t.DeliveryMethod == "Delivery")
                    && ValidateDepositPercent >= 100)
                {
                    OrderType = new LayawayPickup();

                    return "Completed";
                }

                return base.OrderStatus;
            }

            set
            {
                base.OrderStatus = value;
            }
        }

        protected override List<OrderTypeBaseViewModel> GetAvailableTypes()
        {
            var availableTypes = new List<OrderTypeBaseViewModel> { new LayawayDeposit(), new LayawayPickup() };
            bool isRegularCustomerNotGeneric = Customer.CustomerType == CustomerTypes.Regular && !Customer.IsGeneric;
            bool onlyNotSpecialOrderItems = Items.Where(t => t.ItemSku.ItemType == "SKU").All(t => t.ItemSku.SpecialItemType == "normal");
            bool isPickupOrder = Items.Where(t => t.ItemSku != null && t.ItemSku.ItemType == "SKU").All(t => t.DeliveryMethod == "Pick" || t.DeliveryMethod == "Take" || t.DeliveryMethod == "Delivery");

            if (!isRegularCustomerNotGeneric)
            {
                availableTypes.ForEach(t => t.WarningMessages.Add(Strings.NotForGenericMessage));
            }

            if (!onlyNotSpecialOrderItems)
            {
                availableTypes.ForEach(t => t.WarningMessages.Add(Strings.AllSkuMustBeNormalMessage));
            }

            if (!isPickupOrder)
            {
                availableTypes.Single(t => t is LayawayPickup).WarningMessages.Add(Strings.DeliveryMethodPickOrTakeMessage);
            }
            else if (OrderNumber > 0)
            {
                availableTypes.RemoveAll(t => t.StoreOrderType == "Layaway_Deposit");
                availableTypes.Single(t => t is LayawayPickup).ConfirmationMessage = "Do you want to save as Layaway Order Pickup (consider a 100% deposit)?";
            }

            return availableTypes;
        }

        protected override bool CheckReadOnlyState()
        {
            var isReadOnly = OrderStatus == "Active" && ValidateDepositPercent > 0;
            isReadOnly |= CheckSPVIsPending();
            return isReadOnly;
        }

        protected override bool CheckIsSaveDisable()
        {
            var isDisabled = ExpireDate < DateTime.Now;
            return isDisabled;
        }
    }
}