using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;


namespace YammerCrawlSync.Data
{
    [DataContract]
    public class YammerMessage
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "sender_id")]
        public string SenderID { get; set; }

        [DataMember(Name = "replied_to_id")]
        public string RepliedToID { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "network_id")]
        public string NetworkID { get; set; }

        [DataMember(Name = "message_type")]
        public string MessageType { get; set; }

        [DataMember(Name = "sender_type")]
        public string SenderType { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "web_url")]
        public string WebUrl { get; set; }

        [DataMember(Name = "body")]
        public YammerMessageContent MessageContent { get; set; }

        [DataMember(Name = "thread_id")]
        public string ThreadID { get; set; }

        [DataMember(Name = "client_type")]
        public string ClientType { get; set; }

        [DataMember(Name = "client_url")]
        public string ClientUrl { get; set; }

        [DataMember(Name = "system_message")]
        public bool SystemMessage { get; set; }

        [DataMember(Name = "direct_message")]
        public bool DirectMessage { get; set; }

        [DataMember(Name = "chat_client_sequence")]
        public string ChatClientSequence { get; set; }

        [DataMember(Name = "content_excerpt")]
        public string ContentExcerpt { get; set; }

        [DataMember(Name = "language")]
        public string Language { get; set; }

        [DataMember(Name = "attachments")]
        public List<YammerAttachment> Attachments { get; set; }

        [DataMember(Name = "liked_by")]
        public YammerLikes Likes { get; set; }

        public YammerMessage()
        {
            this.Attachments = new List<YammerAttachment>();
            this.Likes = new YammerLikes();
            this.MessageContent = new YammerMessageContent();
        }
    }

    [DataContract]
    public class YammerMessageContent
    {
        [DataMember(Name = "parsed")]
        public string ParsedText { get; set; }

        [DataMember(Name = "plain")]
        public string PlainText { get; set; }

        [DataMember(Name = "rich")]
        public string RichText { get; set; }

    }

    [DataContract]
    public class YammerAttachment
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "web_url")]
        public string WebUrl { get; set; }

        [DataMember(Name = "inline_url")]
        public string InlineUrl { get; set; }

        [DataMember(Name = "liked_by")]
        public YammerLikes Likes { get; set; }

        public YammerAttachment()
        {
            this.Likes = new YammerLikes();
        }
    }

    [DataContract]
    public class YammerLikes
    {
        [DataMember(Name = "count")]
        public int Count { get; set; }

        [DataMember(Name = "names")]
        public List<YammerLikeUser> Names { get; set; }

        public YammerLikes()
        {
            this.Names = new List<YammerLikeUser>();
        }
    }

    [DataContract]
    public class YammerLikeUser
    {
        [DataMember(Name = "full_name")]
        public string FullName { get; set; }

        [DataMember(Name = "permalink")]
        public string PermaLink { get; set; }

        [DataMember(Name = "user_id")]
        public string UserID { get; set; }
    }

    [DataContract]
    public class YammerMessages : SerializedJson<YammerMessages>
    {
        [DataMember(Name = "messages")]
        public List<YammerMessage> Messages { get; set; }

        public YammerMessages()
        {
            this.Messages = new List<YammerMessage>();
        }
    }
}
