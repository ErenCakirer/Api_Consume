using Newtonsoft.Json;

namespace RapidApi.Models
{
    public class BookingApiLocationSearchVM
    {
       
        [JsonProperty("destination_id")]
        public string destinationId { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }
    }
}