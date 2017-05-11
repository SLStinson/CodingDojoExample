using System;
using System.Xml.Serialization;

namespace EsendexMessengerApp.Models
{
    [XmlRoot("messageheaders", Namespace = "http://api.esendex.com/ns/")]
    public class DispatcherResponse
    {
        [XmlAttribute("batchid")]
        public Guid BatchId { get; set; }

        [XmlElement("messageheader")]
        public MessageHeader[] Headers { get; set; }
    }
}