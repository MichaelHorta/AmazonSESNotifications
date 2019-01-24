using System;
using NUnit.Framework;
using SNSNotificationForAmazonSES.Models;

namespace SNSNotificationForAmazonSESTests
{
    public class ComplaintNotificationTest
    {
        [Test(Description = "Should serialize a complaint notification (formatted as JSON) in an object")]
        public void SerializeBounceNotification()
        {
            AmazonSESComplaintNotification complaintNotification = null;
            var resource = ResourceManager.RetrieveEmbeddedResource("complaint-notification-content.json");
            if (null != resource)
            {
                complaintNotification = Newtonsoft.Json.JsonConvert.DeserializeObject<AmazonSESComplaintNotification>(resource);
            }

            Assert.IsTrue(null != complaintNotification);
        }
    }
}
