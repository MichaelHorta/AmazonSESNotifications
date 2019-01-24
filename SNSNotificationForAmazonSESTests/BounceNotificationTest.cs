using NUnit.Framework;
using SNSNotificationForAmazonSES.Models;

namespace SNSNotificationForAmazonSESTests
{
    [TestFixture]
    public class BounceNotificationTest
    {
        [Test(Description = "Should serialize a bounce notification (formatted as JSON) in an object")]
        public void SerializeBounceNotification()
        {
            AmazonSESBounceNotification bounceNotification = null;
            var resource = ResourceManager.RetrieveEmbeddedResource("bounce-notification-content.json");
            if (null != resource)
            {
                bounceNotification = Newtonsoft.Json.JsonConvert.DeserializeObject<AmazonSESBounceNotification>(resource);
            }

            Assert.IsTrue(null != bounceNotification);
        }
    }
}
