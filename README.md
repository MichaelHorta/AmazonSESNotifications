Notifications For Amazon SES (.NET)
===============================

[![Nuget badge](https://buildstats.info/nuget/AmazonSESNotifications)](https://www.nuget.org/packages/AmazonSESNotifications)

Nuget
-----
You can find nuget package with name ```AmazonSESNotifications```

Example of content for ```notification``` variable
-------

Obtained from <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/notification-contents.html">Developer Guide of Amazon Simple Email Service</a>

```JSON
{
  "notificationType": "Delivery",
  "mail": {
    "timestamp": "2018-10-08T14:05:45 +0000",
    "messageId": "000001378603177f-7a5433e7-8edb-42ae-af10-f0181f34d6ee-000000",
    "source": "sender@example.com",
    "sourceArn": "arn:aws:ses:us-west-2:888888888888:identity/example.com",
    "sourceIp": "127.0.3.0",
    "sendingAccountId": "123456789012",
    "destination": [
      "recipient@example.com"
    ],
    "headersTruncated": false,
    "headers": [
      {
        "name": "From",
        "value": "\"Sender Name\" <sender@example.com>"
      },
      {
        "name": "To",
        "value": "\"Recipient Name\" <recipient@example.com>"
      },
      {
        "name": "Message-ID",
        "value": "custom-message-ID"
      },
      {
        "name": "Subject",
        "value": "Hello"
      },
      {
        "name": "Content-Type",
        "value": "text/plain; charset=\"UTF-8\""
      },
      {
        "name": "Content-Transfer-Encoding",
        "value": "base64"
      },
      {
        "name": "Date",
        "value": "Mon, 08 Oct 2018 14:05:45 +0000"
      }
    ],
    "commonHeaders": {
      "from": [
        "Sender Name <sender@example.com>"
      ],
      "date": "Mon, 08 Oct 2018 14:05:45 +0000",
      "to": [
        "Recipient Name <recipient@example.com>"
      ],
      "messageId": " custom-message-ID",
      "subject": "Message sent using Amazon SES"
    }
  },
  "delivery": {
    "timestamp": "2014-05-28T22:41:01.184Z",
    "processingTimeMillis": 546,
    "recipients": [
      "success@simulator.amazonses.com"
    ],
    "smtpResponse": "250 ok:  Message 64111812 accepted",
    "reportingMTA": "a8-70.smtp-out.amazonses.com",
    "remoteMtaIp": "127.0.2.0"
  }
}
```
Examples
-------

### Parsing ```unidentified``` notification
```C#
AmazonSESNotification amazonSESNotification = AmazonSESNotification.Parse(notification);
```

### Trying to parse ```unidentified``` notification
```C#
AmazonSESNotification amazonSESNotification = null;
bool parsed = AmazonSESNotification.TryParse(notification, out amazonSESNotification);
```

### Working with```AmazonSESBounceNotification``` notification
```C#
AmazonSESBounceNotification amazonSESBounceNotification = new AmazonSESBounceNotification(notification);
```
```C#
AmazonSESBounceNotification amazonSESBounceNotification = AmazonSESBounceNotification.Parse(notification);
```
```C#
AmazonSESNotification amazonSESNotification = null;
bool parsed = AmazonSESBounceNotification.TryParse(notification, out amazonSESNotification);
AmazonSESBounceNotification amazonSESBounceNotification = amazonSESNotification as AmazonSESBounceNotification;
```

### Working with```AmazonSESComplaintNotification``` notification
```C#
AmazonSESComplaintNotification amazonSESComplaintNotification = new AmazonSESComplaintNotification(notification);
```
```C#
AmazonSESComplaintNotification amazonSESComplaintNotification = AmazonSESComplaintNotification.Parse(notification);
```
```C#
AmazonSESNotification amazonSESNotification = null;
bool parsed = AmazonSESComplaintNotification.TryParse(notification, out amazonSESNotification);
AmazonSESComplaintNotification amazonSESComplaintNotification = amazonSESNotification as AmazonSESComplaintNotification;
```

### Working with```AmazonSESDeliveryNotification``` notification
```C#
AmazonSESDeliveryNotification amazonSESDeliveryNotification = new AmazonSESDeliveryNotification(notification);
```
```C#
AmazonSESDeliveryNotification amazonSESDeliveryNotification = AmazonSESDeliveryNotification.Parse(notification);
```
```C#
AmazonSESNotification amazonSESNotification = null;
bool parsed = AmazonSESDeliveryNotification.TryParse(notification, out amazonSESNotification);
AmazonSESDeliveryNotification amazonSESDeliveryNotification = amazonSESNotification as AmazonSESDeliveryNotification;
```

Unit tests
-------
After build the project **AmazonSESNotificationsTests**, run unit tests with the tool **console runner** installed by the package <a href="https://www.nuget.org/packages/NUnit.ConsoleRunner/">NUnit.ConsoleRunner</a>

`$ packages\NUnit.ConsoleRunner.3.9.0\tools\nunit3-console.exe NotificationForAmazonSESTests\bin\Debug\AmazonSESNotificationsTests.dll`