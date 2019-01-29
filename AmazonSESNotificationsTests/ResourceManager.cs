using System.IO;
using System.Reflection;

namespace AmazonSESNotificationsTests
{
    public class ResourceManager
    {

        /// <summary>
        /// Retrieve the embedded resource as string.
        /// </summary>
        /// <param name="resourceName"></param>
        /// <returns></returns>
        public static string RetrieveEmbeddedResource(string resourceName)
        {
            using (Stream stream = RetrieveEmbeddedResourceAsStream(resourceName))
            {
                StreamReader reader = new StreamReader(stream);
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Retrieve the embedded resource as byte array.
        /// </summary>
        /// <param name="resourceName"></param>
        /// <returns></returns>
        public static byte[] RetrieveEmbeddedResourceAsByteArray(string resourceName)
        {
            using (Stream resFileStream = RetrieveEmbeddedResourceAsStream(resourceName))
            {
                if (resFileStream == null) return null;
                byte[] bytes = new byte[resFileStream.Length];
                resFileStream.Read(bytes, 0, bytes.Length);
                return bytes;
            }
        }

        /// <summary>
        /// Retrieve the embedded resource as stream.
        /// </summary>
        /// <param name="resourceName"></param>
        /// <returns></returns>
        public static Stream RetrieveEmbeddedResourceAsStream(string resourceName)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(string.Format("{0}.{1}", "SNSNotificationForAmazonSESTests.Resources", resourceName));
        }
    }
}
