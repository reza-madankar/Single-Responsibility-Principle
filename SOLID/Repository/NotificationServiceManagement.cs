using SOLID.Model;
using SOLID.Services;


// Dependency Inversion Principle (DIP)

namespace SOLID.Repository
{
    public class NotificationServiceManagement : INotificationService
    {
        private readonly IEmailService _emailService;
        private readonly ISmsService _smsService;

        public NotificationServiceManagement(IEmailService emailService, ISmsService smsService)
        {
            _emailService = emailService;
            _smsService = smsService;
        }

        public void SendOrderConfirmation(Order order)
        {
            _emailService.SendEmail(order.CustomerName, "Order Confirmation", "Your order has been processed.");
            _smsService.SendSms(order.CustomerName, "Your order has been processed successfully.");
        }
    }
}
