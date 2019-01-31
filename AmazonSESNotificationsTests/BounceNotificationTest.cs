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
            AmazonSESBounceNotification amazonSESBounceNotification = null;
            var notification = ResourceManager.RetrieveEmbeddedResource("bounce-notification-content.json");
            if (null != notification)
            {
                AmazonSESBounceNotification.Parse(notification);
                amazonSESBounceNotification = new AmazonSESBounceNotification(notification);
            }

            AmazonSESNotification amazonSESNotification = null;
            bool parsed = AmazonSESBounceNotification.TryParse(notification, out amazonSESNotification);
            AmazonSESBounceNotification amazonSESBounceNotification2 = amazonSESNotification as AmazonSESBounceNotification;

            Assert.IsTrue(null != amazonSESBounceNotification);
        }
    }
}
