using System.ComponentModel.DataAnnotations;

namespace Fucha.DomainClasses
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
