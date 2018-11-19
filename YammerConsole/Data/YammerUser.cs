using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Diagnostics;


namespace YammerCrawlSync.Data
{
    [DataContract]
    public class YammerUser : SerializedJson<YammerUser>
    {
        [DataMember(Name = "id")]
        public string UserID { get; set; }

        [DataMember(Name = "network_id")]
        public string NetworkID { get; set; }

        [DataMember(Name = "state")]
        public string AccountStatus { get; set; }

        [DataMember(Name = "job_title")]
        public string JobTitle { get; set; }

        [DataMember(Name = "expertise")]
        public string Expertise { get; set; }
        
        [DataMember(Name = "full_name")]
        public string FullName { get; set; }

        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }

        [DataMember(Name = "last_name")]
        public string LastName { get; set; }

        [DataMember(Name = "url")]
        public string ApiUrl { get; set; }

        [DataMember(Name = "web_url")]
        public string WebUrl { get; set; }

        [DataMember(Name = "mugshot_url")]
        public string PhotoUrl { get; set; }

        [DataMember(Name = "mugshot_url_template")]
        public string PhotoTemplateUrl { get; set; }

        [DataMember(Name = "department")]
        public string Department { get; set; }

        [DataMember(Name = "contact")]
        public YammerContactInfo ContactInfo { get; set; }

        [DataMember(Name = "web_preferences")]
        public YammerSettingsAndFeedsAndGroups SettingsAndFeedsAndGroups { get; set; }

        [DataMember(Name = "previous_companies")]
        public List<YammerEmployer> PreviousEmployers { get; set; }

        [DataMember(Name = "schools")]
        public List<YammerSchool> Schools { get; set; }

        [DataMember(Name = "stats")]
        public YammerUserStats UserStats { get; set; }

        public YammerUser()
        {
            this.ContactInfo = new YammerContactInfo();
            this.SettingsAndFeedsAndGroups = new YammerSettingsAndFeedsAndGroups();
            this.PreviousEmployers = new List<YammerEmployer>();
            this.Schools = new List<YammerSchool>();
            this.UserStats = new YammerUserStats();
        }
    }

    [DataContract]
    public class YammerUserStats
    {
        [DataMember(Name = "followers")]
        public int Followers { get; set; }

        [DataMember(Name = "following")]
        public int Following { get; set; }

        [DataMember(Name = "updates")]
        public int Updates { get; set; }
    }

    [DataContract]
    public class YammerSchool
    {
        [DataMember(Name = "degree")]
        public string Degree { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "end_year")]
        public string EndYear { get; set; }

        [DataMember(Name = "start_year")]
        public string StartYear { get; set; }

        [DataMember(Name = "school")]
        public string School { get; set; }
    }

    [DataContract]
    public class YammerEmployer
    {
        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "employer")]
        public string Employer { get; set; }

        [DataMember(Name = "end_year")]
        public string EndYear { get; set; }

        [DataMember(Name = "position")]
        public string Position { get; set; }

        [DataMember(Name = "start_year")]
        public string StartYear { get; set; }
    }

    [DataContract]
    public class YammerSettingsAndFeedsAndGroups
    {
        [DataMember(Name = "network_settings")]
        public YammerNetworkSettings NetworkSettings {get;set;}

        [DataMember(Name = "home_tabs")]
        public List<YammerGroupsAndFeeds> GroupsAndFeeds { get; set; }

        public YammerSettingsAndFeedsAndGroups()
        {
            this.NetworkSettings = new YammerNetworkSettings();
            this.GroupsAndFeeds = new List<YammerGroupsAndFeeds>();
        }
    }

    [DataContract]
    public class YammerGroupsAndFeeds
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "select_name")]
        public string SelectName { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "feed_description")]
        public string Description { get; set; }

        [DataMember(Name = "ordering_index")]
        public int OrderingIndex { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "group_id")]
        public string GroupID { get; set; }

        [DataMember(Name = "private")]
        public bool IsPrivate { get; set; }
   }

    [DataContract]
    public class YammerNetworkSettings
    {
        [DataMember(Name = "message_prompt")]
        public string MessagePrompt { get; set; }

        [DataMember(Name = "allow_attachments")]
        public bool AllowAttachments { get; set; }

        [DataMember(Name = "show_communities_directory")]
        public bool ShowCommunitiesDirectory { get; set; }

        [DataMember(Name = "enable_groups")]
        public bool EnableGroups { get; set; }

        [DataMember(Name = "allow_yammer_apps")]
        public bool AllowYammerApps { get; set; }

        [DataMember(Name = "admin_can_delete_messages")]
        public bool AdminCanDeleteMessages { get; set; }

        [DataMember(Name = "allow_inline_document_view")]
        public bool AllowInlineDocumentView { get; set; }

        [DataMember(Name = "allow_inline_video")]
        public bool AllowInlineVideo { get; set; }

        [DataMember(Name = "enable_private_messages")]
        public bool EnablePrivateMessages { get; set; }

        [DataMember(Name = "allow_external_sharing")]
        public bool AllowExternalSharing { get; set; }

        [DataMember(Name = "enable_chat")]
        public bool EnableChat { get; set; }
    }

    [DataContract]
    public class YammerContactInfo
    {
        [DataMember(Name = "has_fake_email")]
        public bool HasFakeEmail { get; set; }

        [DataMember(Name = "email_addresses")]
        public List<YammerEmailAddresses> EmailAddresses { get; set; }

        [DataMember(Name = "phone_numbers")]
        public List<YammerPhoneNumbers> PhoneNumbers { get; set; }

        [DataMember(Name = "im")]
        public YammerIM IM { get; set; }

        public YammerContactInfo()
        {
            this.EmailAddresses = new List<YammerEmailAddresses>();
            this.PhoneNumbers = new List<YammerPhoneNumbers>();
            this.IM = new YammerIM();
        }
    }

    [DataContract]
    public class YammerEmailAddresses
    {
        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        public YammerEmailAddresses() { }

        public YammerEmailAddresses(string address, string type)
        {
            this.Address = address;
            this.Type = type;
        }
    }

    [DataContract]
    public class YammerPhoneNumbers
    {
        [DataMember(Name = "number")]
        public string PhoneNumber { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }
    }

    [DataContract]
    public class YammerIM
    {
        [DataMember(Name = "provider")]
        public string Provider { get; set; }

        [DataMember(Name = "username")]
        public string UserName { get; set; }
    }
}
