using System.Xml.Serialization;

namespace EsendexMessengerApp.Models
{
    public class DispatcherMessage
    {
        [XmlElement("to")]
        public string Recipient { get; set; }

        [XmlElement("from")]
        public string Originator { get; set; }

        [XmlElement("body")]
        public string Body { get; set; }
    }
}