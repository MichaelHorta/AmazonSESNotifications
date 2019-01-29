using Newtonsoft.Json;
using AmazonSESNotifications.Models.Objects;

namespace AmazonSESNotifications.Models
{
    public class AmazonSESBounceNotification : AmazonSESNotification
    {
        [JsonProperty("bounce")]
        public BounceObject Bounce { get; set; }
    }
}
