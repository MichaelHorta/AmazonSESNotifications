using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SNSNotificationForAmazonSES.Models.Objects
{
    public class DeliveryObject
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("processingTimeMillis")]
        public int ProcessingTimeMillis { get; set; }

        [JsonProperty("recipients")]
        public List<string> Recipients { get; set; }

        [JsonProperty("smtpResponse")]
        public string SmtpResponse { get; set; }

        [JsonProperty("remoteMtaIp")]
        public string RemoteMtaIp { get; set; }

        [JsonProperty("reportingMTA")]
        public string ReportingMTA { get; set; }
    }
}
