using System.Collections.Generic;
using Mi9.Store.Localization;


namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    /// <summary>
    /// All available statuses for Scc agreement.
    /// </summary>
    public static class SccStatus
    {
        // !!! DO NOT CHANGE THE VALUES, THESE ARE HARDCODED IN FRONTEND 
        public const string New = "new";
        public const string Sent = "sent";
        public const string Quoted = "quoted";
        public const string Won = "won";
        public const string Lost = "lost";
        public const string Authorized = "authorized";
        public const string Finalized = "finalized";
        public const string Expired = "expired";
        public const string Cancelled = "cancelled";
        public const string Rejected = "rejected";
        public const string Unknown = "unknown";

        public static readonly IDictionary<string, string> Dict = new Dictionary<string, string>
                {
                    // todo: replace strings with localized resources
                    { New, Strings.SCC_Status_New },
                    { Sent, Strings.SCC_Status_Send },
                    { Quoted, Strings.SCC_Status_Quoted },
                    { Won, Strings.SCC_Status_Won },
                    { Lost, Strings.SCC_Status_Lost },
                    { Authorized, Strings.SCC_Status_Authorized },
                    { Finalized, Strings.SCC_Status_Finalized },
                    { Expired, Strings.SCC_Status_Expired },
                    { Cancelled, Strings.SCC_Status_Cancelled },
                    { Rejected, Strings.SCC_Status_Rejected },
                    { Unknown, Strings.SCC_Status_Unknown } };
        
    };

    /// <summary>
    /// All available statuses for Scc Item.
    /// </summary>
    public static class SccItemStatus
    {
        // !!! DO NOT CHANGE THE VALUES, THESE ARE HARDCODED IN FRONTEND 
        public const string New = "new";
        public const string Quoted = "quoted";
        public const string Rejected = "rejected";
        public const string Accepted = "accepted";
        public const string Pending = "pending";
        //public const string RejectedCustomer = "rejectedCustomer";
        public const string Sold = "sold";
        public const string Unknown = "unknown";

        public static readonly IDictionary<string, string> Dict = new Dictionary<string, string>
                {
                    // todo: replace strings with localized resources
                    { New, Strings.SCC_ItemStatus_New },
                    { Quoted, Strings.SCC_ItemStatus_Quoted },
                    { Rejected, Strings.SCC_ItemStatus_Rejected },
                    { Accepted, Strings.SCC_ItemStatus_Accepted },
                    { Pending, Strings.SCC_ItemStatus_Pending },
                    /*{ RejectedCustomer, Strings.SCC_ItemStatus_RejectedCustomer },*/
                    { Sold, Strings.SCC_ItemStatus_Sold },
                    { Unknown, Strings.SCC_ItemStatus_Unknown }
                };
    }


    /// <summary>
    /// The SccStateFlow interface.
    /// </summary>
    public interface ISccStateFlow
    {
        /// <summary>
        /// The determine state.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        StatusViewModel[] DetermineItemState(string state);

        /// <summary>
        /// The determine agreement state.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        StatusViewModel[] DetermineAgreementState(string state);

        /// <summary>
        /// The determine backend state.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        StatusViewModel[] DetermineItemBackendState(string state);

        /// <summary>
        /// The determine agreement backend state.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        StatusViewModel[] DetermineAgreementBackendState(string state);
    }
}