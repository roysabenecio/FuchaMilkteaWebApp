﻿namespace Fucha.DataLayer.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? UserName { get; set; }
        //public string? Password { get; set; }
        public string Password { get; set; }

        public string? Role { get; set; }
        public string? UserStatus { get; set; }
        public string? DateCreated { get; set; }
        //public bool IsRemoved { get; set; }
    }
}
