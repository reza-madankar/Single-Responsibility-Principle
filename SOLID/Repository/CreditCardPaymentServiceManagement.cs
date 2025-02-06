using SOLID.Model;
using SOLID.Services;


// Liskov Substitution Principle (LSP)

namespace SOLID.Repository
{
    public class CreditCardPaymentService_Management : IPaymentService
    {
        public void ProcessPayment(Order order)
        {
            // Process payment via credit card
            Console.WriteLine("Processing payment via Credit Card...");
            order.IsPaid = true;
        }
    }
}
