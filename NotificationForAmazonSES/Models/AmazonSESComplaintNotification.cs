using Newtonsoft.Json;
using NotificationForAmazonSES.Models.Objects;

namespace NotificationForAmazonSES.Models
{
    public class AmazonSESComplaintNotification : AmazonSESNotification
    {
        [JsonProperty("complaint")]
        public ComplaintObject Complaint { get; set; }
    }
}
