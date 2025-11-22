using System.ComponentModel.DataAnnotations;

namespace BlackHawk.Data.Models
{
    // a container for a specific comic
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public required string Title { get; set; }

        public string? Grade { get; set; }

        // e.g. the pricing identifier on PriceCharting
        public string? ExternalId { get; set; }

        public required string UserGUID { get; set; }

        public List<PricePoint> PriceHistory { get; set; } = [];
    }
}
