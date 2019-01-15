using Newtonsoft.Json;
using SNSNotificationForAmazonSES.Models.Objects;

namespace SNSNotificationForAmazonSES.Models
{
    public class AmazonSESBounceNotification : AmazonSESNotification
    {
        [JsonProperty("bounce")]
        public BounceObject Bounce { get; set; }
    }
}
