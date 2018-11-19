// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EstimateOrderViewModel.cs" company="Home Depot Corporation">
//   Copyright (c) 2012 Home Depot Corporation. All rights reserved.
// </copyright>
// <summary>
//   The estimate order view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Mi9.Store.Localization;
using Mi9.Store.ViewModels.ViewModels.Enums;

namespace Mi9.Store.ViewModels.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The estimate order view model.
    /// </summary>
    public class EstimateOrderViewModel : OrderViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateOrderViewModel"/> class.
        /// </summary>
        public EstimateOrderViewModel()
        {
            this.OrderType = new Estimate();
            this.Customer = new RequiredCustomerViewModel();
        }

        /// <summary>
        /// The get availiable types.
        /// </summary>
        /// <returns>
        /// The availiable order types.
        /// </returns>
        protected override List<OrderTypeBaseViewModel> GetAvailableTypes()
        {
            var availableTypes = new List<OrderTypeBaseViewModel> 
            {
                new Estimate(),
                new CashOnDelivery(), 
                new Regular(),
                new LayawayDeposit(),
                new AccountReceivable(), new SpecialDeposit(),
                new AccountReceivableSpecialDeposit()
            };

            //if (this.Items.Where(t => t.ItemSku.ItemType == "SKU").Any(t => t.DeliveryMethod == "Delivery") && this.Customer.IsGeneric)
            //{
            //    bool needNotGenericName = !string.IsNullOrWhiteSpace(this.Customer.FirstName)
            //                              && this.Customer.FirstName != "Generic"
            //                              && this.Customer.FirstName != "CLIENTE EFECTIVO";
            //    if (!needNotGenericName)
            //    {
            //        foreach (var availableType in availableTypes.Where(t => t is Estimate || t is Regular || t is CashOnDelivery))
            //        {
            //            availableType.WarningMessages.Add(Strings.GenericMustHaveNameMessage);
            //        }
            //    }
            //}

            bool onlyNotSpecialOrderItems = this.Items.Where(t => t.ItemSku.ItemType == "SKU").All(t => t.ItemSku.SpecialItemType == "normal");
            if (onlyNotSpecialOrderItems)
            {
                foreach (var specialOrderTypes in availableTypes.Where(t => t is ISpecialOrderType))
                {
                    specialOrderTypes.WarningMessages.Add(Strings.SkuMustBeSpecialMessage);
                }

                bool availableCustomerTypes = this.Customer.CustomerType != CustomerTypes.ProWithAr
                                       || (this.Customer.CustomerType == CustomerTypes.ProWithAr
                                           && this.Customer.AvailableCredits == "Cash");
                bool isRegularNotGenericCustomer = this.Customer.CustomerType == CustomerTypes.Regular && !this.Customer.IsGeneric;
                bool onlyArCustomer = this.Customer.CustomerType == CustomerTypes.ProWithAr;
                bool notExeedsAvailableCredit = this.Items.Sum(t => t.ExtendedAmount) <= this.Customer.AvailableCredit;

                if (!availableCustomerTypes)
                {
                    foreach (var source in availableTypes.Where(t => t is Regular))
                    {
                        source.WarningMessages.Add(Strings.OrderTypeNotForARCustomerMessage);
                    }
                }

                //if (!isRegularNotGenericCustomer)
                //{
                //    availableTypes.Single(t => t is CashOnDelivery).WarningMessages.Add(Strings.NotForGenericMessage);
                //}

                if (!isRegularNotGenericCustomer)
                {
                    availableTypes.Single(t => t is LayawayDeposit).WarningMessages.Add(Strings.NotForGenericMessage);
                }

                if (!onlyArCustomer)
                {
                    availableTypes.Single(t => t is AccountReceivable).WarningMessages.Add(Strings.OnlyForARCustomerMessage);
                }

                if (!notExeedsAvailableCredit)
                {
                    availableTypes.Single(t => t is AccountReceivable).WarningMessages.Add(Strings.ExceedsAvailableCreditMessage);
                }
            }
            else
            {
                foreach (var notSpecialOrderTypes in availableTypes.Where(t => t is INotSpecialOrderType))
                {
                    notSpecialOrderTypes.WarningMessages.Add(Strings.AllSkuMustBeNormalMessage);
                }

                bool isAvailableCustomer = !this.Customer.IsGeneric || (this.Customer.CustomerType == CustomerTypes.ProWithAr && this.Customer.AvailableCredits == "Cash");
                bool onlyArCustomer = this.Customer.CustomerType == CustomerTypes.ProWithAr;
                bool notExeedsAvailableCredit = this.Items.Sum(t => t.ExtendedAmount) <= this.Customer.AvailableCredit;

                if (!onlyArCustomer)
                {
                    availableTypes.Single(t => t is AccountReceivableSpecialDeposit).WarningMessages.Add(Strings.OnlyForARCustomerMessage);
                }

                if (!notExeedsAvailableCredit)
                {
                    availableTypes.Single(t => t is AccountReceivableSpecialDeposit).WarningMessages.Add(Strings.ExceedsAvailableCreditMessage);
                }

                if (!isAvailableCustomer)
                {
                    availableTypes.Single(t => t is SpecialDeposit).WarningMessages.Add(Strings.OnlyForCashAndNotGeneric);
                }
            }

            return availableTypes;
        }
    }
}
