using Newtonsoft.Json;
using SNSNotificationForAmazonSES.Models.Objects;

namespace SNSNotificationForAmazonSES.Models
{
    public class AmazonSESComplaintNotification : AmazonSESNotification
    {
        [JsonProperty("complaint")]
        public ComplaintObject Complaint { get; set; }
    }
}
