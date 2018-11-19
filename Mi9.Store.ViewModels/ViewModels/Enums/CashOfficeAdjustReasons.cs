using System.ComponentModel;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum CashOfficeAdjustReasons
    {
        [Description("loan")]
        Loan,
        [Description("deposit")]
        Deposit,
        [Description("pickup")]
        Pickup,
        [Description("balance")]
        Balance,
        [Description("adjustment")]
        Adjustment,
        [Description("media entry")]
        MediaEntry
    }  
}
