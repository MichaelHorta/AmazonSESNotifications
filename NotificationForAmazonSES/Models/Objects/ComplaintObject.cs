using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AmazonSESNotifications.Models.Objects
{
    public class ComplaintObject
    {
        [JsonProperty("complainedRecipients")]
        public List<ComplainedRecipient> ComplainedRecipients;

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("feedbackId")]
        public string FeedbackId { get; set; }

        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        [JsonProperty("complaintFeedbackType")]
        public string ComplaintFeedbackType { get; set; }

        [JsonProperty("arrivalDate")]
        public DateTime ArrivalDate { get; set; }
    }

    public class ComplainedRecipient
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
    }
}
