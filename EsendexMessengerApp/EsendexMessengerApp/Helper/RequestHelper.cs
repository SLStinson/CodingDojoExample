using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using EsendexMessengerApp.Models;

namespace EsendexMessengerApp.Helper
{
    public static class RequestHelper
    {
        public static string GenerateRequestBody(DispatcherRequest dispatcherRequest)
        {
            var ns = new XmlSerializerNamespaces();
            const string defaultNamespace = "http://api.esendex.com/ns/";
            ns.Add(string.Empty, defaultNamespace);

            var builder = new StringBuilder();

            using (var writer = new StringWriter(builder))
            using (var xmlTextWriter = new XmlTextWriter(writer))
            {
                var xmlSerializer = new XmlSerializer(typeof(DispatcherRequest), defaultNamespace);
                xmlSerializer.Serialize(xmlTextWriter, dispatcherRequest, ns);
            }

            return builder.ToString();
        }
    }
}