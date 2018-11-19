﻿using System;

namespace Mi9.Store.Entities.Entities
{
    public class GeneratedScheduleEntity
    {
        public int EmployeeId { get; set; }

        public DateTime Date { get; set; }

        public byte HourOfDay { get; set; }

        public decimal? HourPart { get; set; }

        public int? ReasonId { get; set; }

        public bool IsOverNight { get; set; }

        public virtual ReasonTypeEntity ReasonType { get; set; }

        public EmployeeEntity Employee { get; set; }
    }
}