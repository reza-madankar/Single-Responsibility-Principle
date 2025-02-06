using SOLID.Model;
using SOLID.Services;



namespace SOLID.Context
{
    public class OrderService
    {
        private readonly IDiscountCalculator _discountCalculator;
        private readonly IPaymentService _paymentService;
        private readonly INotificationService _notificationService;

        public OrderService(IDiscountCalculator discountCalculator, IPaymentService paymentService, INotificationService notificationService)
        {
            _discountCalculator = discountCalculator;
            _paymentService = paymentService;
            _notificationService = notificationService;
        }

        public void ProcessOrder(Order order)
        {
            double discount = _discountCalculator.CalculateDiscount(order);
            order.Amount -= discount;

            _paymentService.ProcessPayment(order);
            _notificationService.SendOrderConfirmation(order);
        }
    }
}
