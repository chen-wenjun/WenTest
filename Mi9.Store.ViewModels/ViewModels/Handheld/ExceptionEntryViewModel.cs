using MI9.HDM.Store.BackOffice.Core.Handheld;
using Newtonsoft.Json;
using System;

namespace Mi9.Store.ViewModels.ViewModels.Handheld
{
    /// <summary>
    /// View/Model for the ExceptionEntry entity
    /// </summary>
    public class ExceptionEntryViewModel
    {
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [JsonProperty(PropertyName = "HResult")]
        public LogPriorityEnum HResult { get; set; }

        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the Source.
        /// </summary>
        [JsonProperty(PropertyName = "Source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [JsonProperty(PropertyName = "InnerMessage")]
        public string InnerMessage { get; set; }

        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [JsonProperty(PropertyName = "InnerSource")]
        public string InnerSource { get; set; }

        /// <summary>
        /// Gets or sets the StackTrace.
        /// </summary>
        [JsonProperty(PropertyName = "StackTrace")]
        public string StackTrace { get; set; }

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
