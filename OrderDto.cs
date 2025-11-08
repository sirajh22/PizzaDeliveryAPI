namespace PIzzaDeliveryAPI.DTOs
{
    public class OrderDto
    {
        public  int Id { get; set; }
        public  string? UserName { get; set; }
        public  string? PizzaName { get; set; }
        public  int Quantity { get; set; }
        public  string Status { get; set; }
        public  DateTime OrderDate { get; set; }
    }
}
