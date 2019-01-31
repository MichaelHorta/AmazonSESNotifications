using Newtonsoft.Json;
using AmazonSESNotifications.Models.Objects;

namespace AmazonSESNotifications.Models
{
    public class AmazonSESBounceNotification : AmazonSESNotification
    {
        [JsonProperty("bounce")]
        public BounceObject Bounce { get; set; }

        public AmazonSESBounceNotification()
        {

        }

        public AmazonSESBounceNotification(string notification)
        {
            AmazonSESNotification amazonSESNotification = null;
            if (TryParse(notification, out amazonSESNotification))
            {
                var amazonSESBounceNotification = amazonSESNotification as AmazonSESBounceNotification;
                Mail = amazonSESBounceNotification.Mail;
                NotificationType = amazonSESBounceNotification.NotificationType;
                Bounce = amazonSESBounceNotification.Bounce;
            }
        }

        public new static AmazonSESBounceNotification Parse(string notification)
        {
            return (AmazonSESBounceNotification)ParseTool.ParseAmazonSESNotification(notification, true, typeof(AmazonSESBounceNotification));
        }

        public new static bool TryParse(string notification, out AmazonSESNotification amazonSESNotification)
        {
            return ParseTool.TryParseAmazonSESNotification(notification, out amazonSESNotification, true, typeof(AmazonSESBounceNotification));
        }
    }
}
