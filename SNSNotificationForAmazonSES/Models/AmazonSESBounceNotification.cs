using Newtonsoft.Json;
using NotificationForAmazonSES.Models.Objects;

namespace NotificationForAmazonSES.Models
{
    public class AmazonSESBounceNotification : AmazonSESNotification
    {
        [JsonProperty("bounce")]
        public BounceObject Bounce { get; set; }
    }
}
