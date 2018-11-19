using MI9.HDM.Store.BackOffice.Core.Handheld;
using Newtonsoft.Json;
using System;

namespace Mi9.Store.ViewModels.ViewModels.Handheld
{
    /// <summary>
    /// View/Model for the LogEntry entity
    /// </summary>
    public class LogEntryViewModel
    {
        /// <summary>
        /// Gets or sets the Priority.
        /// </summary>
        [JsonProperty(PropertyName = "Priority")]
        public LogPriorityEnum Priority { get; set; }

        /// <summary>
        /// Gets or sets the Source.
        /// </summary>
        [JsonProperty(PropertyName = "Source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [JsonProperty(PropertyName = "Text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the TimeStamp.
        /// </summary>
        [JsonProperty(PropertyName = "TimeStamp")]
        public DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }
    }
}
