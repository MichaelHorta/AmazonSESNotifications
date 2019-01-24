using Newtonsoft.Json;
using NotificationForAmazonSES.Models.Objects;

namespace NotificationForAmazonSES.Models
{
    public class AmazonSESDeliveryNotification : AmazonSESNotification
    {
        [JsonProperty("delivery")]
        public DeliveryObject Delivery { get; set; }
    }
}
