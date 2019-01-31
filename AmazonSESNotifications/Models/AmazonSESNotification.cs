using Newtonsoft.Json;
using AmazonSESNotifications.Models.Objects;
using System;

namespace AmazonSESNotifications.Models
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

        public static AmazonSESNotification Parse(string notification)
        {
            return ParseTool.ParseAmazonSESNotification(notification);
        }

        public static bool TryParse(string notification, out AmazonSESNotification amazonSESNotification)
        {
            return ParseTool.TryParseAmazonSESNotification(notification, out amazonSESNotification);
        }
    }
}