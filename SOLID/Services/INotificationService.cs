using SOLID.Model;


// Dependency Inversion Principle (DIP)

namespace SOLID.Services
{
    public interface INotificationService
    {
        void SendOrderConfirmation(Order order);
    }
}
