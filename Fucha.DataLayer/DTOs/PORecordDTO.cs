namespace Fucha.DataLayer.DTOs
{
    public class PORecordDTO
    {
        //public int Id { get; set; }
        public string Stock { get; set; }
        public string Category { get; set; }
        public double Measure { get; set; }
        public string MeasurementUnit { get; set; }
        public int ReceivedOrders { get; set; }
        public double Price { get; set; }
        //public string DatePurchased { get; set; }
        public string Supplier { get; set; }
        //public int PurchaseRecordId { get; set; }
        public int UserId { get; set; }
    }
}
