using Fucha.DomainClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.DTOs
{
    public class UserSampleDTO : BaseEntity
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? UserName { get; set; }
        //public string? Password { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        [Required]
        public string? Role { get; set; }
        public string? UserStatus { get; set; }
        public string? DateCreated { get; set; }
        public bool IsRemoved { get; set; } = false;

    }
}
