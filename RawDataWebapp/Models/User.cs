using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;

namespace RawDataWebapp.Models
{
    public class User
    {
        // UserId is not necessary for JSON file storage, but you can keep it if needed
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [MaxLength(256, ErrorMessage = "Username must be at most 256 characters long")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MaxLength(256, ErrorMessage = "Password must be at most 256 characters long")]
        public string Password { get; set; }

        // Parameterless constructor for deserialization
        public User() { }

        // Constructor to initialize properties
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
