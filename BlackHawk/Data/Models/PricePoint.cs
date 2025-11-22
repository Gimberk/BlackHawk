namespace BlackHawk.Data.Models
{
    // used for charting the pricing history
    public class PricePoint
    {
        public int Id { get; set; }

        // the id of the item the pricepoint refers back to
        public int ItemId { get; set; }

        public DateTimeOffset RecordTime { get; set; }

        // apparently for monetary values, it's best to use a decimal which has insane precision
        public decimal Price { get; set; }

        // e.g. PriceCharting or Ebay
        public required string Source { get; set; }
    }
}
