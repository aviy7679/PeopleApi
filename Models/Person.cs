using System.ComponentModel.DataAnnotations;
namespace PeopleApi.Models
{
    public class Person
    {
        
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string ImagePath { get; set; } = string.Empty;
    }
}
