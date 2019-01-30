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
            AmazonSESNotification amazonSESNotification = null;
            var settings = new JsonSerializerSettings { MissingMemberHandling = MissingMemberHandling.Error };
            var subTypes = Util.AmazonSESNotificationsSubTypes();
            foreach(var type in subTypes)
            {
                try
                {
                    amazonSESNotification = JsonConvert.DeserializeObject(notification, type, settings) as AmazonSESNotification;
                    break;
                }
                catch (Exception ex)
                {
                    if (ex is JsonSerializationException)
                    {
                        continue;
                    }
                }
            }

            return amazonSESNotification;
        }

        public static bool TryParse(string notification, out AmazonSESNotification amazonSESNotification)
        {
            amazonSESNotification = null;
            var settings = new JsonSerializerSettings { MissingMemberHandling = MissingMemberHandling.Error };
            var subTypes = Util.AmazonSESNotificationsSubTypes();
            bool parsed = false;
            foreach (var type in subTypes)
            {
                try
                {
                    amazonSESNotification = JsonConvert.DeserializeObject(notification, type, settings) as AmazonSESNotification;
                    parsed = true;
                    break;
                }
                catch (Exception ex)
                {
                    if (ex is JsonSerializationException)
                    {
                        continue;
                    }
                }
            }

            return parsed;
        }
    }
}
