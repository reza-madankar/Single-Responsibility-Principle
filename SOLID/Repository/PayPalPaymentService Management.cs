using SOLID.Model;
using SOLID.Services;


// Liskov Substitution Principle (LSP)

namespace SOLID.Repository
{
    public class PayPalPaymentService_Management : IPaymentService
    {

        public void ProcessPayment(Order order)
        {
            // Process payment via PayPal
            Console.WriteLine("Processing payment via PayPal...");
            order.IsPaid = true;
        }
    }
}
