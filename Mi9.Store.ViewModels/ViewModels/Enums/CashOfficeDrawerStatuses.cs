using System.ComponentModel;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum CashOfficeDrawerStatuses
    {
        [Description("unopened")]
        UnOpened,
        [Description("issued")]
        Issued,
        [Description("unbalanced")]
        Unbalanced,
        [Description("closed")]
        Closed
    }
}
