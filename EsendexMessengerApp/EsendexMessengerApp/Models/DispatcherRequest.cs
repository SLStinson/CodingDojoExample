using System.Xml.Serialization;
using RestSharp.Serializers;

namespace EsendexMessengerApp.Models
{
    [XmlRoot("messages")]
    public class DispatcherRequest
    {
        [XmlElement("accountreference")]
        [SerializeAs(Name = "accountreference")]
        public string AccountReference { get; set; }

        [XmlElement("message")]
        [SerializeAs(Name = "messages")]
        public DispatcherMessage[] Messages { get; set; }
    }
}