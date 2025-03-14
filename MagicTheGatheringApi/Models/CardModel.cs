namespace MagicTheGatheringApi.Models
{
    public class CardModel
    {
        public string? name { get; set; }
        public string? manaCost { get; set; }
        public float? cmc { get; set; }
        public List<string>? colors { get; set; }
        public List<string>? colorIdentity { get; set; }
        public string? type { get; set; }
        public List<string>? types { get; set; }
        public List<string>? subtypes { get; set; }
        public string? rarity { get; set; }
        public string? set { get; set; }
        public string? setName { get; set; }
        public string? text { get; set; }
        public string? artist { get; set; }
        public string? number { get; set; }
        public string? power { get; set; }
        public string? toughness { get; set; }
        public string? layout { get; set; }
        public string? multiverseId { get; set; }
        public string? imageUrl { get; set; }
        public List<string>? variations { get; set; }
        public List<ForeignName>? foreignNames { get; set; }
        public List<string>? printings { get; set; }
        public string? originalText { get; set; }
        public string? originalType { get; set; }
        public List<Legality>? legalities { get; set; }
        public string? id { get; set; }
    }
}