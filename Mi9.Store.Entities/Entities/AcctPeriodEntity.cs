using System;

namespace Mi9.Store.Entities.Entities
{
    public class AcctPeriodEntity
    {
        public bool IDX_FIELD { get; set; }
        public byte WeekBeginDay { get; set; }
        public bool TwentyFour { get; set; }
        public byte CollecPeriod { get; set; }
        public DateTime? DateLastXmit { get; set; }
        public string AcctStatus { get; set; }
        public byte EndOfDaySunday { get; set; }
        public byte EndOfDayMonday { get; set; }
        public byte EndOfDayTuesday { get; set; }
        public byte EndOfDayWednesday { get; set; }
        public byte EndOfDayThursday { get; set; }
        public byte EndOfDayFriday { get; set; }
        public byte EndOfDaySaturday { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime? NextDate { get; set; }
        public byte TranRetain { get; set; }
        public byte CurrentCP { get; set; }
        public DateTime? CurrentDate { get; set; }
        public byte CurRptCP { get; set; }
        public DateTime? CurRptDate { get; set; }
        public bool AutoClose { get; set; }
        public TimeSpan TimeClose { get; set; }
        public bool AutoCloseOvr { get; set; }
        public string CurrentTran { get; set; }
        public string LastTran { get; set; }
        public byte EOPStatus { get; set; }
        public DateTime? LastEOD { get; set; }
        public string ProgName { get; set; }
        public TimeSpan ProgStartTim { get; set; }
        public bool EODErrorFlag { get; set; }
        public string OpenClose { get; set; }
        public TimeSpan TimeCpClose__1 { get; set; }
        public TimeSpan TimeCpClose__2 { get; set; }
        public TimeSpan TimeCpClose__3 { get; set; }
        public bool AutoDrwrClose { get; set; }
    }
}
