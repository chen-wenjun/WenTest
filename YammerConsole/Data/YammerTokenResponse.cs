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
    public class YammerTokenResponse
    {
        [DataMember(Name = "user_id")]
        public string UserID { get; set; }

        [DataMember(Name = "network_id")]
        public string NetworkID { get; set; }

        [DataMember(Name = "network_permalink")]
        public string NetworkPermaLink { get; set; }

        [DataMember(Name = "network_name")]
        public string NetworkName { get; set; }

        [DataMember(Name = "token")]
        public string Token { get; set; }
    }

    [DataContract]
    public class YammerAccessToken : SerializedJson<YammerAccessToken>
    {
        [DataMember(Name = "access_token")]
        public YammerTokenResponse TokenResponse { get; set; }

        [DataMember(Name = "user")]
        public YammerUser CurrentUser { get; set; }

        public YammerAccessToken()
        {
            this.TokenResponse = new YammerTokenResponse();
            this.CurrentUser = new YammerUser();
        }
    }
}
