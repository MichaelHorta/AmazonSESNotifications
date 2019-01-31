using Newtonsoft.Json;
using AmazonSESNotifications.Models.Objects;

namespace AmazonSESNotifications.Models
{
    public class AmazonSESComplaintNotification : AmazonSESNotification
    {
        [JsonProperty("complaint")]
        public ComplaintObject Complaint { get; set; }

        public AmazonSESComplaintNotification()
        {

        }

        public AmazonSESComplaintNotification(string notification)
        {
            AmazonSESNotification amazonSESNotification = null;
            if (TryParse(notification, out amazonSESNotification))
            {
                var amazonSESComplaintNotification = amazonSESNotification as AmazonSESComplaintNotification;
                Mail = amazonSESComplaintNotification.Mail;
                NotificationType = amazonSESComplaintNotification.NotificationType;
                Complaint = amazonSESComplaintNotification.Complaint;
            }
        }

        public new static AmazonSESComplaintNotification Parse(string notification)
        {
            return (AmazonSESComplaintNotification)ParseTool.ParseAmazonSESNotification(notification, true,typeof(AmazonSESComplaintNotification));
        }

        public new static bool TryParse(string notification, out AmazonSESNotification amazonSESNotification)
        {
            return ParseTool.TryParseAmazonSESNotification(notification, out amazonSESNotification, true, typeof(AmazonSESComplaintNotification));
        }
    }
}
