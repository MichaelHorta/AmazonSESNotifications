using Newtonsoft.Json;
using NotificationForAmazonSES.Models.Objects;

namespace NotificationForAmazonSES.Models
{
    /// <summary>
    /// Amazon SES Notification Published to Amazon SNS.
    /// <see cref="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/notification-contents.html"/>
    /// </summary>
    public abstract class AmazonSESNotification
    {

        [JsonProperty("notificationType")]
        public string NotificationType { get; set; }

        [JsonProperty("mail")]
        public MailObject Mail { get; set; }
    }
}
