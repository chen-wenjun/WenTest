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
    public class YammerImpersonate : SerializedJson<YammerImpersonate>
    {
        [DataMember()]
        public List<YammerToken> Tokens { get; set; }
    }

    [DataContract]
    public class YammerToken
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
        public string AccessToken { get; set; }

        [DataMember(Name = "secret")]
        public string Secret { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedTime { get; set; }

        [DataMember(Name = "authorized_at")]
        public string AuthorizedTime { get; set; }
    }
}
