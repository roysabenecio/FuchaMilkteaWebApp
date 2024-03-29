﻿using System.ComponentModel.DataAnnotations;

namespace Fucha.DataLayer.DTOs
{
    public class LoginCredentialsDTO
    {
        public int Id { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
