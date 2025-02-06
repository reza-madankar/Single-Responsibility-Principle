
// Interface Segregation Principle (ISP)

namespace SOLID.Services
{
    public interface ISmsService
    {
        void SendSms(string to, string message);
    }
}
