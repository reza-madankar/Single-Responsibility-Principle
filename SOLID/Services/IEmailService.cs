
// Interface Segregation Principle (ISP)
namespace SOLID.Services
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
