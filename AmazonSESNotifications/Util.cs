using AmazonSESNotifications.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AmazonSESNotifications
{
    public static class Util
    {
        public static IList<Type> AmazonSESNotificationsSubTypes()
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
