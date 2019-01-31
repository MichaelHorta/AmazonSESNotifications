using AmazonSESNotifications.Models;
using NUnit.Framework;

namespace AmazonSESNotificationsTests
{
    public class ComplaintNotificationTest
    {
        [Test(Description = "Should serialize a complaint notification (formatted as JSON) in an object")]
        public void SerializeComplaintNotification()
        {
            AmazonSESComplaintNotification complaintNotification = null;
            var notification = ResourceManager.RetrieveEmbeddedResource("complaint-notification-content.json");
            if (null != notification)
            {
                complaintNotification = new AmazonSESComplaintNotification(notification);
            }

            Assert.IsTrue(null != complaintNotification);
        }
    }
}
