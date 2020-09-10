using System.ComponentModel.DataAnnotations;

namespace WebAPI.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(8,MinimumLength = 4,ErrorMessage="Password should be between 4 to 8 length")]
        public string Password { get; set; }
    }
}