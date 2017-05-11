using System.IO;
using System.Xml.Serialization;
using EsendexMessengerApp.Models;
using RestSharp;

namespace EsendexMessengerApp.Helper
{
    public static class ResponseHelper
    {
        public static MessageHeader DeserializeMessageHeaderResponse(IRestResponse response)
        {
            var reader = new StringReader(response.Content);
            return new XmlSerializer(typeof(MessageHeader)).Deserialize(reader) as MessageHeader;
        }

        public static DispatcherResponse DeserializeDispatcherResponse(IRestResponse response)
        {
            var reader = new StringReader(response.Content);
            return new XmlSerializer(typeof(DispatcherResponse)).Deserialize(reader) as DispatcherResponse;
        }
    }
}