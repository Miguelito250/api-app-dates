using System.ComponentModel.DataAnnotations;

namespace Models.UserProfile
{
    public class UserProfile
    {
        [Key]
        [Required]
        public required Guid UUID { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        public required string Birthdate { get; set; }
        public string? Biography { get; set; }
    }
}