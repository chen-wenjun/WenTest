namespace Mi9.Store.ViewModels.ViewModels
{
    using System;

    using Newtonsoft.Json;

    public class InstallerStatusViewModel
    {
        private static readonly InstallerStatusViewModel _active = new InstallerStatusViewModel { Id = 1, DatabaseId = "A", Name = "Active" };

        private static readonly InstallerStatusViewModel _suspended = new InstallerStatusViewModel { Id = 2, DatabaseId = "S", Name = "Suspended" };

        private static readonly InstallerStatusViewModel _deleted = new InstallerStatusViewModel { Id = 3, DatabaseId = "D", Name = "Delete" };

        private static readonly InstallerStatusViewModel _eliminated = new InstallerStatusViewModel { Id = 4, DatabaseId = "E", Name = "Eliminated" };

        public static InstallerStatusViewModel Active
        {
            get
            {
                return _active;
            }
        }

        public static InstallerStatusViewModel Suspended
        {
            get
            {
                return _suspended;
            }
        }

        public static InstallerStatusViewModel Deleted
        {
            get
            {
                return _deleted;
            }
        }

        public static InstallerStatusViewModel Eliminated
        {
            get
            {
                return _eliminated;
            }
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public string DatabaseId { get; set; }

        public static InstallerStatusViewModel Identify(int statusId)
        {
            if (statusId == _active.Id)
            {
                return Active;
            }

            if (statusId == _suspended.Id)
            {
                return Suspended;
            }

            if (statusId == _deleted.Id)
            {
                return Deleted;
            }

            if (statusId == _eliminated.Id)
            {
                return Eliminated;
            }

            throw new ArgumentOutOfRangeException("statusId");
        }

        public static InstallerStatusViewModel Identify(string databaseId)
        {
            if (databaseId.Equals(_active.DatabaseId, StringComparison.OrdinalIgnoreCase))
            {
                return Active;
            }

            if (databaseId.Equals(_suspended.DatabaseId, StringComparison.OrdinalIgnoreCase))
            {
                return Suspended;
            }

            if (databaseId.Equals(_deleted.DatabaseId, StringComparison.OrdinalIgnoreCase))
            {
                return Deleted;
            }

            if (databaseId.Equals(_eliminated.DatabaseId, StringComparison.OrdinalIgnoreCase))
            {
                return Eliminated;
            }

            throw new ArgumentOutOfRangeException("databaseId");
        }

        public static string GetDatabaseId(int statusId)
        {
            if (statusId == _active.Id)
            {
                return Active.DatabaseId;
            }

            if (statusId == _suspended.Id)
            {
                return Suspended.DatabaseId;
            }

            if (statusId == _deleted.Id)
            {
                return Deleted.DatabaseId;
            }

            if (statusId == _eliminated.Id)
            {
                return Eliminated.DatabaseId;
            }

            throw new ArgumentOutOfRangeException("statusId");
        }

        public bool ShouldSerializeDatabaseId()
        {
            return false;
        }
    }
}