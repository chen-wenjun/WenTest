using System.Collections.Generic;
using System.Linq;
using Mi9.Store.Localization;
using Mi9.Store.ViewModels.ViewModels.Enums;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class AccountReceivableSpecialOrderViewModel : OrderViewModel, IAdvanceCancellationOrder
    {
        public AccountReceivableSpecialOrderViewModel()
        {
            OrderType = new AccountReceivableSpecialDeposit();
            Customer = new RequiredCustomerViewModel();
        }

        public override string OrderStatus
        {
            get
            {
                if (Items.Where(t => t.ItemSku != null && t.ItemSku.ItemType == "SKU").All(t => t.DeliveryMethod == "Pick" || t.DeliveryMethod == "Take" || t.DeliveryMethod == "Delivery")
                    && ValidateDepositPercent >= 100)
                {
                    OrderType = new AccountReceivableSpecialPickup();
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
            var availableTypes = new List<OrderTypeBaseViewModel>
                                                     {
                                                         new AccountReceivableSpecialDeposit(),
                                                         new AccountReceivableSpecialPickup()
                                                     };
            var onlyArCustomer = Customer.CustomerType == CustomerTypes.ProWithAr;
            var notExeedsAvailableCredit = Items.Sum(t => t.ExtendedAmount) <= Customer.AvailableCredit;
            var hasSpecialOrderItems = Items.Where(t => t.ItemSku.ItemType == "SKU").Any(t => t.ItemSku.SpecialItemType != "normal");
            var isPickupOrder = Items.Where(t => t.ItemSku != null && t.ItemSku.ItemType == "SKU").All(t => t.DeliveryMethod == "Pick" || t.DeliveryMethod == "Take" || t.DeliveryMethod == "Delivery");

            if (!onlyArCustomer)
            {
                availableTypes.ForEach(t => t.WarningMessages.Add(Strings.OnlyForARCustomerMessage));
            }

            if (!notExeedsAvailableCredit)
            {
                availableTypes.ForEach(t => t.WarningMessages.Add(Strings.ExceedsAvailableCreditMessage));
            }

            if (!hasSpecialOrderItems)
            {
                availableTypes.ForEach(t => t.WarningMessages.Add(Strings.SkuMustBeSpecialMessage));
            }

            if (!isPickupOrder)
            {
                availableTypes.Single(t => t is AccountReceivableSpecialPickup).WarningMessages.Add(Strings.DeliveryMethodPickOrTakeMessage);
            }
            else
            {
                availableTypes.RemoveAll(t => t.StoreOrderType == "AR_Special_Order_Deposit");
                availableTypes.Single(t => t is AccountReceivableSpecialPickup).ConfirmationMessage = "Do you want to save as A/R Special Order Pickup?";
            }

            if (availableTypes.Count(x => !x.WarningMessages.Any()) <= 0)
            {
                if (onlyArCustomer)
                {
                    availableTypes.Add(new Estimate());
                    if (Customer.AvailableCredits == "Cash")
                    {
                        availableTypes.Add(new Regular());
                        availableTypes.Add(new CashOnDelivery());
                    }

                    if (notExeedsAvailableCredit)
                    {
                        availableTypes.Add(new AccountReceivable());
                    }
                }
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