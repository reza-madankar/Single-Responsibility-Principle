using SOLID.Model;


// Liskov Substitution Principle (LSP)

namespace SOLID.Services
{
    public interface IPaymentService
    {
        void ProcessPayment(Order order);
    }
}
