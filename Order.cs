namespace PIzzaDeliveryAPI.Models
{
    public class Order
    {
        public  int Id { get; set; }
        public DateTime OrderdDate { get; set; } = DateTime.Now;
        public  int UserId  { get; set; }
        public  User User { get; set; } //relational to user
        public  int PizzaId { get; set; }
        public  Pizza Pizza { get; set; }//relational to pizza
        public int Quantity { get; set; }
        public  string Status { get; set; }
    }   
}
