namespace PIzzaDeliveryAPI.DTOs
{
    public class CreateOrderDto
    {
        public  int UserId { get; set; }
        public int PizzaId { get; set; }
        public  int Quantity { get; set; }
        public  string Status { get; set; }
    }
}
