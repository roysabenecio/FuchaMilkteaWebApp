using Fucha.DomainClasses;

namespace Fucha.DataLayer.DTOs
{
    public class StockDTO : BaseEntity
    {
        public string? Name { get; set; }
        public double Measure { get; set; }
        public string MeasurementUnit { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public double? CriticalLevel { get; set; }
        public double? LowLevel { get; set; }
        public double? OverStockLevel { get; set; }
        //public string? DateAdded { get; set; }
        public string? LastRestocked { get; set; }
        public string? Supplier { get; set; }
        public bool IsRemoved { get; set; }
    }
}
