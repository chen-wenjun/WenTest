using System;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The inventory control entity.
    /// </summary>
    public class InventoryControlEntity
    {
        /// <summary>
        /// Gets or sets a value indicating whether id.
        /// </summary>
        public bool Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether replenish.
        /// </summary>
        public bool Replenish { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether use history.
        /// </summary>
        public bool UseHistory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has kits.
        /// </summary>
        public bool HasKits { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether alt price.
        /// </summary>
        public bool AltPrice { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether retail meth.
        /// </summary>
        public bool RetailMeth { get; set; }

        /// <summary>
        /// Gets or sets the SKU XREF.
        /// </summary>
        public string SKUXref { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether assign UPC.
        /// </summary>
        public bool AssignUPC { get; set; }

        /// <summary>
        /// Gets or sets the purge delay.
        /// </summary>
        public short PurgeDelay { get; set; }

        /// <summary>
        /// Gets or sets the change day.
        /// </summary>
        public byte ChangeDay { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether auto change.
        /// </summary>
        public bool AutoChange { get; set; }

        /// <summary>
        /// Gets or sets the cost calc.
        /// </summary>
        public byte CostCalc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether sku purge.
        /// </summary>
        public bool SKUPurge { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether order code.
        /// </summary>
        public bool OrderCode { get; set; }

        /// <summary>
        /// Gets or sets the retain days.
        /// </summary>
        public byte RetainDays { get; set; }

        /// <summary>
        /// Gets or sets the alpha search.
        /// </summary>
        public string AlphaSearch { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether explode opt.
        /// </summary>
        public bool ExplodeOpt { get; set; }

        /// <summary>
        /// Gets or sets the round table 1 below.
        /// </summary>
        public short RoundTbl1Below { get; set; }

        /// <summary>
        /// Gets or sets the round table 2 below.
        /// </summary>
        public short RoundTbl2Below { get; set; }

        /// <summary>
        /// Gets or sets the round table 3 below.
        /// </summary>
        public short RoundTbl3Below { get; set; }

        /// <summary>
        /// Gets or sets the round table 4 below.
        /// </summary>
        public short RoundTbl4Below { get; set; }

        /// <summary>
        /// Gets or sets the round table 5 below.
        /// </summary>
        public short RoundTbl5Below { get; set; }

        /// <summary>
        /// Gets or sets the round table 6 below.
        /// </summary>
        public short RoundTbl6Below { get; set; }

        /// <summary>
        /// Gets or sets the round table 7 below.
        /// </summary>
        public short RoundTbl7Below { get; set; }

        /// <summary>
        /// Gets or sets the round table 8 below.
        /// </summary>
        public short RoundTbl8Below { get; set; }

        /// <summary>
        /// Gets or sets the round table 9 below.
        /// </summary>
        public short RoundTbl9Below { get; set; }

        /// <summary>
        /// Gets or sets the round table 0 below.
        /// </summary>
        public short RoundTbl0Below { get; set; }

        /// <summary>
        /// Gets or sets the round table 1 above.
        /// </summary>
        public short RoundTbl1Above { get; set; }

        /// <summary>
        /// Gets or sets the round table 2 above.
        /// </summary>
        public short RoundTbl2Above { get; set; }

        /// <summary>
        /// Gets or sets the round table 3 above.
        /// </summary>
        public short RoundTbl3Above { get; set; }

        /// <summary>
        /// Gets or sets the round table 4 above.
        /// </summary>
        public short RoundTbl4Above { get; set; }

        /// <summary>
        /// Gets or sets the round table 5 above.
        /// </summary>
        public short RoundTbl5Above { get; set; }

        /// <summary>
        /// Gets or sets the round table 6 above.
        /// </summary>
        public short RoundTbl6Above { get; set; }

        /// <summary>
        /// Gets or sets the round table 7 above.
        /// </summary>
        public short RoundTbl7Above { get; set; }

        /// <summary>
        /// Gets or sets the round table 8 above.
        /// </summary>
        public short RoundTbl8Above { get; set; }

        /// <summary>
        /// Gets or sets the round table 9 above.
        /// </summary>
        public short RoundTbl9Above { get; set; }

        /// <summary>
        /// Gets or sets the round table 0 above.
        /// </summary>
        public short RoundTbl0Above { get; set; }

        /// <summary>
        /// Gets or sets the break point.
        /// </summary>
        public decimal BreakPoint { get; set; }

        /// <summary>
        /// Gets or sets the year end 1.
        /// </summary>
        public DateTime? YearEnd1 { get; set; }

        /// <summary>
        /// Gets or sets the year end 2.
        /// </summary>
        public DateTime? YearEnd2 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether cost.
        /// </summary>
        public bool Cost { get; set; }

        /// <summary>
        /// Gets or sets the pc audit purge.
        /// </summary>
        public short PCAuditPurge { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether dept history.
        /// </summary>
        public bool DeptHist { get; set; }

        /// <summary>
        /// Gets or sets the history retain.
        /// </summary>
        public short HistRetain { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether rounding.
        /// </summary>
        public bool Rounding { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether auto implement.
        /// </summary>
        public bool AutoImplement { get; set; }

        /// <summary>
        /// Gets or sets the tranfr purge delay.
        /// </summary>
        public short TranfrPurgeDelay { get; set; }

        /// <summary>
        /// Gets or sets the inventory adjustment log purge delay.
        /// </summary>
        public short InvAdjLogPurgeDelay { get; set; }

        /// <summary>
        /// Gets or sets the item maint purge delay.
        /// </summary>
        public short ItemMaintPurgeDelay { get; set; }

        /// <summary>
        /// Gets or sets the ret vend purge delays.
        /// </summary>
        public short RetVendPurgeDelays { get; set; }

        /// <summary>
        /// Gets or sets the comp days.
        /// </summary>
        public short CompDays { get; set; }

        /// <summary>
        /// Gets or sets the promo days.
        /// </summary>
        public short PromoDays { get; set; }

        /// <summary>
        /// Gets or sets the inventory adjustment limit.
        /// </summary>
        public decimal InventoryAdjustmentLimit { get; set; }
    }
}