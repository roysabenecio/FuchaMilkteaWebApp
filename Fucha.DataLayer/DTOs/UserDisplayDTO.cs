using System.Text.Json.Serialization;

namespace Fucha.DataLayer.DTOs
{
    public class UserDisplayDTO
    {
        public int Id { get; set; }

        [JsonPropertyName("First Name")]
        public string? FirstName { get; set; }

        [JsonPropertyName("Last Name")]

        public string? LastName { get; set; }

        [JsonPropertyName("Username")]

        public string? UserName { get; set; }

        [JsonPropertyName("Role")]
        public string? Role { get; set; }

        [JsonPropertyName("User Status")]
        public string? UserStatus { get; set; }

        [JsonPropertyName("Date Created")]
        public string? DateCreated { get; set; }
        public bool IsRemoved { get; set; }
    }
}
