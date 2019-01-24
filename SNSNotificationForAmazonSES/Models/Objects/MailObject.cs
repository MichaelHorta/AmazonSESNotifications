using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NotificationForAmazonSES.Models.Objects
{
    public class MailObject
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("sourceArn")]
        public string SourceArn { get; set; }

        [JsonProperty("sourceIp")]
        public string SourceIp { get; set; }

        [JsonProperty("sendingAccountId")]
        public string SendingAccountId { get; set; }

        [JsonProperty("destination")]
        public List<string> Destination { get; set; }

        [JsonProperty("headersTruncated")]
        public bool HeadersTruncated { get; set; }

        [JsonProperty("headers")]
        public List<HeaderObject> Headers { get; set; }

        [JsonProperty("commonHeaders")]
        public Dictionary<string, object> CommonHeaders { get; set; }
    }

    public class HeaderObject
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
