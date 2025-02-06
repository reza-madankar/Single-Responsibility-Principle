using SOLID.Services;


// Interface Segregation Principle (ISP)

namespace SOLID.Repository
{
    public class SmsNotificationServiceManagement : ISmsService
    {
        public void SendSms(string to, string message)
        {
            Console.WriteLine($"Sending SMS to {to}: {message}");
        }
    }

}