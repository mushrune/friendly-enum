using Newtonsoft.Json;

namespace FriendlyEnum.Examples.Model;

public class Day
{
    [JsonProperty("weather")] public Weather? Weather { get; set; }
    [JsonProperty("date")] public DateTime Date { get; set; }
}