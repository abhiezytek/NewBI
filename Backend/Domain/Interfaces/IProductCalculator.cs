namespace BackEnd.Domain.Interfaces
{
    public interface IProductCalculator
    {
        decimal CalculatePrice(decimal basePrice, decimal taxRate);
        string GetProductDescription(int productId);
    }
}