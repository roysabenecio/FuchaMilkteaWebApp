namespace Fucha.DomainClasses
{
    public class LoginHistory : BaseEntity
    {
        public string? Date { get; set; }
        public string? Description { get; set; }

        public string? User { get; set; }
        public string? Role { get; set; }
    }
}
