using System.Text.Json.Serialization;

namespace TSApi.Models
{
    public class UserData
    {
        public string login { get; set; }

        [JsonIgnore]
        public string passwd { get; set; }

        [JsonIgnore]
        public string domainid { get; set; }

        [Newtonsoft.Json.JsonProperty(NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string torPath { get; set; }

        [JsonIgnore]
        public bool allowedToChangeSettings { get; set; }

        [JsonIgnore]
        public bool IsShared { get; set; }
    }
}
