using System.ComponentModel.DataAnnotations;

namespace PIzzaDeliveryAPI.DTOs
{
    public class CreateUserDto
    {
        [Required(ErrorMessage ="invalid user name")]
        public  string Name { get; set; }
        [Required]
        public  string Email { get; set; }
    }
}
