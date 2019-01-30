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
            var resource = ResourceManager.RetrieveEmbeddedResource("delivery-notification-content.json");

            var parsed = false;
            if (null != resource)
            {
                parsed = AmazonSESNotification.TryParse(resource, out amazonSESNotification);
            }

            Assert.IsTrue(parsed);
        }

        [Test(Description = "Parse a delivery notification (formatted as JSON) in an object")]
        public void ParseDeliveryNotification()
        {
            AmazonSESNotification amazonSESNotification = null;
            var resource = ResourceManager.RetrieveEmbeddedResource("delivery-notification-content.json");
            
            if (null != resource)
            {
                amazonSESNotification = AmazonSESNotification.Parse(resource);
            }

            Assert.IsTrue(null != amazonSESNotification);
        }
    }
}
