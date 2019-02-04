using AmazonSESNotifications.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AmazonSESNotifications
{
    public static class ParseTool
    {
        private static List<Type> amazonSESNotificationSubTypes = new List<Type>()
        {
            typeof(AmazonSESBounceNotification),
            typeof(AmazonSESComplaintNotification),
            typeof(AmazonSESDeliveryNotification)
        };

        public static bool TryParseAmazonSESNotification(string notification, out AmazonSESNotification amazonSESNotification, Type type = null)
        {
            amazonSESNotification = null;
            var settings = new JsonSerializerSettings { MissingMemberHandling = MissingMemberHandling.Error };

            #region Deserializing for a specific type 
            if (null != type)
            {
                try
                {
                    amazonSESNotification = JsonConvert.DeserializeObject(notification, type, settings) as AmazonSESNotification;
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            #endregion
            
            bool parsed = false;
            foreach (var t in amazonSESNotificationSubTypes)
            {
                try
                {
                    amazonSESNotification = JsonConvert.DeserializeObject(notification, t, settings) as AmazonSESNotification;
                    parsed = true;
                    break;
                }
                catch (Exception ex)
                {
                    if (ex is JsonSerializationException)
                    {
                        continue;
                    }
                }
            }

            return parsed;
        }

        public static AmazonSESNotification ParseAmazonSESNotification(string notification, Type type = null)
        {
            AmazonSESNotification amazonSESNotification = null;
            TryParseAmazonSESNotification(notification, out amazonSESNotification, type);
            return amazonSESNotification;
        }
    }
}
