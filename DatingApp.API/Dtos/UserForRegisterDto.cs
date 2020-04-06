using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(12,MinimumLength =4, ErrorMessage="You mus specify password between 4 and 12 characters")]
        public string Password { get; set; }
    }
}