using System.ComponentModel.DataAnnotations;

namespace PIzzaDeliveryAPI.Models
{
    public class Pizza
    {
       
        public int Id { get; set; } //primary key
        [Required(ErrorMessage ="Pizza Name is Required")]
        [MaxLength(100,ErrorMessage ="Pizza Name Cannot exceed 100 characters")]
        public  string Name { get; set; }
        [Range(1,5000,ErrorMessage ="Price Must be Between 1 and 5000")]
        public decimal Price { get; set; }

       
    }
}
