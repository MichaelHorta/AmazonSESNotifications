using Newtonsoft.Json;
using AmazonSESNotifications.Models.Objects;

namespace AmazonSESNotifications.Models
{
    public class AmazonSESDeliveryNotification : AmazonSESNotification
    {
        [JsonProperty("delivery")]
        public DeliveryObject Delivery { get; set; }

        public AmazonSESDeliveryNotification()
        {

        }

        public AmazonSESDeliveryNotification(string notification)
        {
            AmazonSESNotification amazonSESNotification = null;
            if (TryParse(notification, out amazonSESNotification))
            {
                var amazonSESDeliveryNotification = amazonSESNotification as AmazonSESDeliveryNotification;
                Mail = amazonSESDeliveryNotification.Mail;
                NotificationType = amazonSESDeliveryNotification.NotificationType;
                Delivery = amazonSESDeliveryNotification.Delivery;
            }
        }

        public new static AmazonSESDeliveryNotification Parse(string notification)
        {
            return (AmazonSESDeliveryNotification) ParseTool.ParseAmazonSESNotification(notification, typeof(AmazonSESDeliveryNotification));
        }

        public new static bool TryParse(string notification, out AmazonSESNotification amazonSESNotification)
        {
            return ParseTool.TryParseAmazonSESNotification(notification, out amazonSESNotification, typeof(AmazonSESDeliveryNotification));
        }
    }
}
