
using SOLID.Context;
using SOLID.Model;
using SOLID.Repository;
using SOLID.Services;


// Open/Closed Principle (OCP)
IDiscountCalculator discountCalculator = new VIPDiscountCalculatorManagement();

// Liskov Substitution Principle (LSP)
IPaymentService paymentService = new CreditCardPaymentService_Management();

// Interface Segregation Principle (ISP)
IEmailService emailService = new EmailNotificationServiceManagement();
ISmsService smsService = new SmsNotificationServiceManagement();

// Dependency Inversion Principle (DIP)
INotificationService notificationService = new NotificationServiceManagement(emailService, smsService);

// Single Responsibility Principle (SRP)
OrderService orderService = new OrderService(discountCalculator, paymentService, notificationService);

Order order = new Order
{
    OrderId = 1,
    CustomerName = "Reza Madankar",
    Amount = 100.0
};

orderService.ProcessOrder(order);

Console.WriteLine($"Order processed. Final amount: {order.Amount}. Paid: {order.IsPaid}");