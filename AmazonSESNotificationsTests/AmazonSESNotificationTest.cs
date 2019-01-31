using AmazonSESNotifications.Models;
using AmazonSESNotificationsTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNSNotificationForAmazonSESTests
{
    [TestFixture]
    public class AmazonSESNotificationTest
    {
        [Test(Description = "Trying to parse a delivery notification (formatted as JSON) in an object")]
        public void TryParseDeliveryNotification()
        {
            AmazonSESNotification amazonSESNotification = null;
            var notification = ResourceManager.RetrieveEmbeddedResource("delivery-notification-content.json");

            var parsed = false;
            if (null != notification)
            {
                parsed = AmazonSESNotification.TryParse(notification, out amazonSESNotification);
            }

            Assert.IsTrue(parsed);
        }

        [Test(Description = "Parse a delivery notification (formatted as JSON) in an object")]
        public void ParseDeliveryNotification()
        {
            AmazonSESNotification amazonSESNotification = null;
            var notification = ResourceManager.RetrieveEmbeddedResource("delivery-notification-content.json");
            
            if (null != notification)
            {
                amazonSESNotification = AmazonSESNotification.Parse(notification);
            }

            Assert.IsTrue(null != amazonSESNotification);
        }
    }
}
