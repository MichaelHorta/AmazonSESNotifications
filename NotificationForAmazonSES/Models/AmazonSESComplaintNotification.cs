using Newtonsoft.Json;
using AmazonSESNotifications.Models.Objects;

namespace AmazonSESNotifications.Models
{
    public class AmazonSESComplaintNotification : AmazonSESNotification
    {
        [JsonProperty("complaint")]
        public ComplaintObject Complaint { get; set; }
    }
}
