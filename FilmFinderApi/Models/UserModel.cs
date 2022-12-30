using System;
using System.Text.Json.Serialization;

namespace FilmFinderApi.Models
{
	public class UserModel
	{
        public int UserId { get; set; }

        public string? Username { get; set; }

        public string? TempPassword { get; set; }

        [JsonIgnore]
        public string? PasswordHash { get; set; }

    }
}

