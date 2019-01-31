using AmazonSESNotifications.Models;
using NUnit.Framework;

namespace AmazonSESNotificationsTests
{
    [TestFixture]
    public class BounceNotificationTest
    {
        [Test(Description = "Should serialize a bounce notification (formatted as JSON) in an object")]
        public void SerializeBounceNotification()
        {
            AmazonSESBounceNotification bounceNotification = null;
            var notification = ResourceManager.RetrieveEmbeddedResource("bounce-notification-content.json");
            if (null != notification)
            {
                bounceNotification = new AmazonSESBounceNotification(notification);
            }

            Assert.IsTrue(null != bounceNotification);
        }
    }
}
