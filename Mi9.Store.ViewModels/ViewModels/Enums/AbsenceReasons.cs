using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum AbsenceReasons
    {
        [Description("Incapacities")]
        Incapacities = 1,
        [Description("Store Support")]
        StoreSupport,
        [Description("Training")]
        Training,
        [Description("Vacations")]
        Vacations,
        [Description("Day Off")]
        DayOff
    }

    public class AbsenceReason
    {
        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class AbsenceReasonsCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<AbsenceReason> Items { get; set; }

        public AbsenceReasonsCatalog()
        {
            Items = new List<AbsenceReason>
                {
                    new AbsenceReason
                        {
                            Value = 1,
                            Description = "catalogs.absenceReason.incapacities"
                        },
                    new AbsenceReason
                        {
                            Value = 2,
                            Description = "catalogs.absenceReason.storeSupport"
                        },
                    new AbsenceReason
                        {
                            Value = 3,
                            Description = "catalogs.absenceReason.training"
                        },
                    new AbsenceReason
                        {
                            Value = 4,
                            Description = "catalogs.absenceReason.vacations"
                        },
                    new AbsenceReason
                        {
                            Value = 5,
                            Description = "catalogs.absenceReason.dayOff"
                        }
                };
        }
    }
}
