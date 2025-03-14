using System.Text.Json.Serialization;

namespace MagicTheGatheringApi.Models
{
    public class Legality
    {
        public string? format { get; set; }
        [JsonPropertyName("legality")]
        public string? status { get; set; }
    }
}
