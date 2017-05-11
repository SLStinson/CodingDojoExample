using System.Xml.Serialization;

namespace EsendexMessengerApp.Models
{
    [XmlRoot("messages")]
    public class DispatcherRequest
    {
        [XmlElement("accountreference")]
        public string AccountReference { get; set; }

        [XmlElement("message")]
        public DispatcherMessage[] Messages { get; set; }
    }
}