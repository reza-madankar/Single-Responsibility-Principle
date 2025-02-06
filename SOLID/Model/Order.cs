
namespace SOLID.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = "";
        public double Amount { get; set; }
        public bool IsPaid { get; set; }
    }
}
