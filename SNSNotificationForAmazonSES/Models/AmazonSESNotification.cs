using Newtonsoft.Json;
using SNSNotificationForAmazonSES.Models.Objects;

namespace SNSNotificationForAmazonSES.Models
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
