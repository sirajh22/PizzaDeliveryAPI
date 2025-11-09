using System.ComponentModel.DataAnnotations;

namespace PIzzaDeliveryAPI.DTOs
{
    public class CreatePizzaDto
    {
        [Required]
        public string Name { get;set; }
        [Range(1,5000)]
        public decimal Price { get; set; }
    }
}
