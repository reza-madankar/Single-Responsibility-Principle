using SOLID.Model;


// Open/Closed Principle (OCP)

namespace SOLID.Services
{
    public interface IDiscountCalculator
    {
        double CalculateDiscount(Order order);
    }
}
