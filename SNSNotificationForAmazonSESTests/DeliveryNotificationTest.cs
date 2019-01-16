using NUnit.Framework;
using SNSNotificationForAmazonSES.Models;

namespace SNSNotificationForAmazonSESTests
{
    [TestFixture]
    public class DeliveryNotificationTest
    {
        [Test(Description = "Should serialize a delivery notification (formatted as JSON) in an object")]
        public void SerializeDeliveryNotification()
        {
            var resource = ResourceManager.RetrieveEmbeddedResource("delivery-notification-content");
            var deliveryNotification = Newtonsoft.Json.JsonConvert.DeserializeObject<AmazonSESDeliveryNotification>(resource);
            Assert.IsTrue(null != deliveryNotification);
        }
    }
}
