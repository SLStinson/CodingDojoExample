using Newtonsoft.Json;

namespace EsendexMessengerApp.Models
{
    public class DispatcherMessage
    {
        [JsonProperty("to")]
        public string Recipient { get; set; }

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string Originator { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}