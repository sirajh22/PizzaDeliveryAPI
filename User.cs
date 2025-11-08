using System.ComponentModel.DataAnnotations;

namespace PIzzaDeliveryAPI.Models
{
    public class User
    {
        public  int Id { get; set; }
        [Required(ErrorMessage ="invalid user name")]
        public  string Name { get; set; }
        [Required]
        [EmailAddress]
        public  string Email { get; set; }
        

    }
}
