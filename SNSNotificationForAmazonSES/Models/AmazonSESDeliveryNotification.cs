using Newtonsoft.Json;
using SNSNotificationForAmazonSES.Models.Objects;

namespace SNSNotificationForAmazonSES.Models
{
    public class AmazonSESDeliveryNotification : AmazonSESNotification
    {
        [JsonProperty("delivery")]
        public DeliveryObject Delivery { get; set; }
    }
}
