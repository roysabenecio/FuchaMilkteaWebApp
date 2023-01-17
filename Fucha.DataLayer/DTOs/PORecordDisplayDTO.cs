using System.Text.Json.Serialization;

namespace Fucha.DataLayer.DTOs
{
    public class PORecordDisplayDTO
    {
        public int Id { get; set; }
        public string? Stock { get; set; }
        public string? Category { get; set; }
        public double Measure { get; set; }
        [JsonPropertyName("uom")]

        public string? MeasurementUnit { get; set; }
        public double Price { get; set; }
        [JsonPropertyName("Date Purchased")]

        public string? DatePurchased { get; set; }

        public string? Status { get; set; }
        [JsonPropertyName("Received")]

        public int? ReceivedOrders { get; set; }

        public string? Supplier { get; set; }
        public string? User { get; set; }
    }
}
