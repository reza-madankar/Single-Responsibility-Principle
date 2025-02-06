using SOLID.Model;
using SOLID.Services;


// Open/Closed Principle (OCP)

namespace SOLID.Repository
{
    public class VIPDiscountCalculatorManagement : IDiscountCalculator
    {
        public double CalculateDiscount(Order order)
        {
            return order.Amount * 0.1;  
        }
    } 
}
