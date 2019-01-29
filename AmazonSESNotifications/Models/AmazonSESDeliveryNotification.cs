using Newtonsoft.Json;
using AmazonSESNotifications.Models.Objects;

namespace AmazonSESNotifications.Models
{
    public class AmazonSESDeliveryNotification : AmazonSESNotification
    {
        [JsonProperty("delivery")]
        public DeliveryObject Delivery { get; set; }
    }
}
