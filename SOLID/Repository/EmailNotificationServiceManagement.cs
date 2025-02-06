using SOLID.Services;


// Interface Segregation Principle (ISP)

namespace SOLID.Repository
{
    public class EmailNotificationServiceManagement : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email to {to}: {subject}");
        }
    }
}
