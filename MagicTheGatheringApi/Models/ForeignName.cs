﻿namespace MagicTheGatheringApi.Models
{
    public class ForeignName
    {
        public string? name { get; set; }
        public string? text { get; set; }
        public string? type { get; set; }
        public string? flavor { get; set; }
        public string? imageUrl { get; set; }
        public string? language { get; set; }
        public Identifiers? identifiers { get; set; }
        public int? multiverseid { get; set; }
    }
}
