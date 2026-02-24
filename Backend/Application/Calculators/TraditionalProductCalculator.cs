using System;

namespace Backend.Application.Calculators
{
    public class TraditionalProductCalculator
    {
        // Method to calculate Death Benefit
        public decimal CalculateDeathBenefit(decimal sumAssured, decimal premiumPaid, int tenure)
        {
            // Simplified calculation for death benefit
            return sumAssured - premiumPaid + (tenure * 1000); // Example adjustment
        }

        // Method to calculate Guaranteed Maturity Benefit (GMB)
        public decimal CalculateGMB(decimal premium, int years)
        {
            return premium * years * 1.05m; // Example return value
        }

        // Method to calculate Guaranteed Surrender Value (GSV)
        public decimal CalculateGSV(decimal premiumsPaid, decimal surrenderFactor)
        {
            return premiumsPaid * surrenderFactor; // Example calculation
        }

        // Method to calculate Special Surrender Value (SSV)
        public decimal CalculateSSV(decimal totalPaid, decimal bonus)
        {
            return totalPaid + bonus; // Simple addition
        }
    }
}