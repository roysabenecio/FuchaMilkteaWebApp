namespace Fucha.DomainClasses
{
    public class ActivityHistory : BaseEntity
    {
        public string? User { get; set; }
        public string? Activity { get; set; }
        public string? Module { get; set; }
        public string? Date { get; set; }
    }
}
