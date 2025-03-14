namespace MagicTheGatheringMVC.Models
{
    public class CardModel
    {
        public string? name { get; set; }
        public string? manaCost { get; set; }
        public float? cmc { get; set; }
        public List<string>? colors { get; set; }
        public string? setName { get; set; }
        public string? imageUrl { get; set; }
        public string? id { get; set; }
    }
}