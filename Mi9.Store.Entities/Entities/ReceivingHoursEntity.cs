using System;

namespace Mi9.Store.Entities.Entities
{
    public class ReceivingHoursEntity
    {
        public long Id { get; set; }

        public TimeSpan StartDate { get; set; }

        public TimeSpan EndDate { get; set; }

        public bool MondayAvailable { get; set; }

        public bool TuesdayAvailable { get; set; }

        public bool WednesdayAvailable { get; set; }

        public bool ThursdayAvailable { get; set; }

        public bool FridayAvailable { get; set; }

        public bool SaturdayAvailable { get; set; }

        public bool SundayAvailable { get; set; }

        public virtual PricingAgreementEntity Agreement { get; set; }
    }
}
