
using System.Collections.Generic;
using System.Linq;
using Mi9.Store.Localization;
using Mi9.Store.ViewModels.ViewModels.Enums;

namespace Mi9.Store.ViewModels.ViewModels
{
    
    public class SpecialOrderViewModel : OrderViewModel, IAdvanceCancellationOrder
    {
        public SpecialOrderViewModel()
        {
            OrderType = new SpecialDeposit();
            Customer = new RequiredCustomerViewModel();
        }

        public override string OrderStatus
        {
            get
            {
                if (Items.Where(t => t.ItemSku != null && t.ItemSku.ItemType == "SKU").All(t => t.DeliveryMethod == "Pick" || t.DeliveryMethod == "Take" || t.DeliveryMethod == "Delivery")
                   && ValidateDepositPercent >= 100)
                {
                    OrderType = new SpecialPickup();
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
            var availableTypes = new List<OrderTypeBaseViewModel> { new SpecialDeposit(), new AccountReceivableSpecialDeposit(), new SpecialPickup() };
            var isAvailableCustomer = !Customer.IsGeneric || (Customer.CustomerType == CustomerTypes.ProWithAr && Customer.AvailableCredits == "Cash");
            var hasSpecialOrderItems = Items.Where(t => t.ItemSku.ItemType == "SKU").Any(t => t.ItemSku.SpecialItemType != "normal");
            var isPickupOrder = Items.Where(t => t.ItemSku != null && t.ItemSku.ItemType == "SKU").All(t => t.DeliveryMethod == "Pick" || t.DeliveryMethod == "Take" || t.DeliveryMethod == "Delivery");
            bool isArAvailable = Customer.CustomerType == CustomerTypes.ProWithAr && Items.Sum(t => t.ExtendedAmount) <= Customer.AvailableCredit;
          
            if (!isAvailableCustomer)
            {
                availableTypes.ForEach(t => t.WarningMessages.Add(Strings.OnlyForCashAndNotGeneric));
            }

            if (!hasSpecialOrderItems)
            {
                availableTypes.ForEach(t => t.WarningMessages.Add(Strings.SkuMustBeSpecialMessage));
            }

            if (!isArAvailable)
            {
                availableTypes.Single(t => t is AccountReceivableSpecialDeposit).WarningMessages.Add(Strings.ExceedsAvailableCreditMessage);
            }

            if (!isPickupOrder)
            {
                availableTypes.Single(t => t is SpecialPickup).WarningMessages.Add(Strings.DeliveryMethodPickOrTakeMessage);
            }
            else
            {
                availableTypes.RemoveAll(t => t.StoreOrderType == "Special_Order_Deposit" || t.StoreOrderType == "AR_Special_Order_Deposit");
                availableTypes.Single(t => t is SpecialPickup).ConfirmationMessage = "Do you want to save as Special Order Pickup (consider a 100% deposit)";
            }


            if (!hasSpecialOrderItems)
            {
                if (isArAvailable)
                {
                    availableTypes.Add(new AccountReceivable());
                }

                availableTypes.Add(new Regular());
                availableTypes.Add(new CashOnDelivery());
                availableTypes.Add(new Estimate());
            }

            return availableTypes;
        }

        protected override bool CheckReadOnlyState()
        {
            var isReadOnly = OrderStatus == "Active" && ValidateDepositPercent > 0;
            isReadOnly |= CheckSPVIsPending();
            return isReadOnly;
        }
    }
}