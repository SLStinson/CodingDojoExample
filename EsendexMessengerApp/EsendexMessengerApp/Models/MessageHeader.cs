using System;
using System.Xml.Serialization;

namespace EsendexMessengerApp.Models
{
    [XmlRoot("messageheader", Namespace = "http://api.esendex.com/ns/")]
    public class MessageHeader
    {
        [XmlAttribute("uri")]
        public string Uri { get; set; }

        [XmlAttribute("id")]
        public Guid Id { get; set; }

        [XmlElement("status")]
        public MessageStatus Status { get; set; }

        public enum MessageStatus
        {
            Submitted, Sent, Delivered, Failed
        }
    }
}