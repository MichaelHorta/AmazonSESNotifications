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

            var subTypes = AmazonSESNotificationsSubTypes();
            bool parsed = false;
            foreach (var t in subTypes)
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

        private static IList<Type> AmazonSESNotificationsSubTypes()
        {
            Assembly asm = typeof(AmazonSESNotification).GetTypeInfo().Assembly;
            var enumerator = asm.DefinedTypes.GetEnumerator();
            var list = new List<Type>();
            while (enumerator.MoveNext())
            {
                TypeInfo typeInfo = enumerator.Current;
                if (typeInfo.BaseType.Name.Equals(typeof(AmazonSESNotification).Name))
                {
                    list.Add(typeInfo.AsType());
                }
            }

            return list;
        }
    }
}
