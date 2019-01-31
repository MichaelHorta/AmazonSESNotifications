using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AmazonSESNotifications.Models.Objects
{
    public class BounceObject
    {
        [JsonProperty("bounceType")]
        public string BounceType { get; set; }

        [JsonProperty("bounceSubType")]
        public string BounceSubType { get; set; }

        [JsonProperty("bouncedRecipients")]
        public List<BouncedRecipient> BouncedRecipients { get; set; }

        [JsonProperty("reportingMTA")]
        public string ReportingMTA { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("feedbackId")]
        public string FeedbackId { get; set; }

        [JsonProperty("remoteMtaIp")]
        public string RemoteMtaIp { get; set; }
    }

    public class BouncedRecipient
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("diagnosticCode")]
        public string DiagnosticCode { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
    }
}
