// IProductCalculatorFactory.cs

namespace Domain.Interfaces
{
    public interface IProductCalculatorFactory
    {
        IProductCalculator CreateCalculator(string calculatorType);
    }
}