namespace Fucha.DataLayer.DTOs
{
    public class SupplierDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public bool IsRemoved { get; set; }
    }
}