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
            AmazonSESDeliveryNotification amazonSESDeliveryNotification = null;
            var notification = ResourceManager.RetrieveEmbeddedResource("delivery-notification-content.json");
            if (null != notification)
            {
                amazonSESDeliveryNotification = new AmazonSESDeliveryNotification(notification);
            }

            Assert.IsTrue(null != amazonSESDeliveryNotification);
        }
    }
}
