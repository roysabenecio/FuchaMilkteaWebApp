using Fucha.DomainClasses;
using System.Text.Json.Serialization;

namespace Fucha.DataLayer.DTOs
{
    public class StockDTO : BaseEntity
    {
        public string? Name { get; set; }
        public double Measure { get; set; }
        [JsonPropertyName("UOM")]
        public string MeasurementUnit { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        [JsonPropertyName("Critical Level")]
        public double? CriticalLevel { get; set; }
        [JsonPropertyName("Low Level")]
        public double? LowLevel { get; set; }
        public double? Ceiling { get; set; }
        //public string? DateAdded { get; set; }
        [JsonPropertyName("Last Restocked")]

        public string? LastRestocked { get; set; }
        public string? Supplier { get; set; }
        public bool IsRemoved { get; set; }
    }
}
