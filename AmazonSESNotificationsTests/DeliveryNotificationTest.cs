using AmazonSESNotifications.Models;
using NUnit.Framework;

namespace AmazonSESNotificationsTests
{
    [TestFixture]
    public class DeliveryNotificationTest
    {
        [Test(Description = "Should serialize a delivery notification (formatted as JSON) in an object")]
        public void SerializeDeliveryNotification()
        {
            AmazonSESDeliveryNotification deliveryNotification = null;
            var notification = ResourceManager.RetrieveEmbeddedResource("delivery-notification-content.json");
            if (null != notification)
            {
                deliveryNotification = new AmazonSESDeliveryNotification(notification);
            }

            Assert.IsTrue(null != deliveryNotification);
        }
    }
}
