namespace MagicTheGatheringApi.Models
{
    public class SetModel
    {
        public string? code { get; set; }
        public string? name { get; set; }
        public string? type { get; set; }
        public string? releaseDate { get; set; }
        public string? block { get; set; }
        public bool? onlineOnly { get; set; }
        public List<object>? booster { get; set; }
    }
}
