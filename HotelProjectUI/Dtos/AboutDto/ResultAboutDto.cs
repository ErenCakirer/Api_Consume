using Newtonsoft.Json; 

namespace HotelProjectUI.Dtos.AboutDto
{
    public class ResultAboutDto
    {
        [JsonProperty("aboutUsID")]
        public int AboutUsID { get; set; }

        [JsonProperty("title1")]
        public string Title1 { get; set; }

        [JsonProperty("title2")]
        public string Title2 { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("roomCount")]
        public int RoomCount { get; set; }

        [JsonProperty("staffCount")]
        public int StaffCount { get; set; }

        [JsonProperty("customerCount")]
        public int CustomerCount { get; set; }
    }
}