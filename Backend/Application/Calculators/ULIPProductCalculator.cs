using System;
using System.Collections.Generic;

namespace Backend.Application.Calculators
{
    public class ULIPProductCalculator
    {
        private decimal premium;
        private decimal mortalityChargeRate;
        private decimal basicCoverage;
        private List<decimal> fundValues;

        public ULIPProductCalculator(decimal premium, decimal mortalityChargeRate, decimal basicCoverage)
        {
            this.premium = premium;
            this.mortalityChargeRate = mortalityChargeRate;
            this.basicCoverage = basicCoverage;
            this.fundValues = new List<decimal>();
        }

        public decimal CalculatePremiumAllocation()
        {
            // Assuming 80% of premium is allocated to funds
            return premium * 0.80m;
        }

        public decimal CalculateMortalityCharge(int age)
        {
            // Simplified mortality charge calculation
            return basicCoverage * mortalityChargeRate * (age / 100m);
        }

        public void ProjectFundValue(int years)
        {
            decimal fundValue = 0;
            for (int i = 0; i < years; i++)
            {
                fundValue += CalculatePremiumAllocation() - CalculateMortalityCharge(30) ; // Assuming age 30 for simplicity
                fundValues.Add(fundValue);
            }
        }

        public decimal CalculateTotalFundValue()
        {
            decimal totalValue = 0;
            foreach (decimal value in fundValues)
            {
                totalValue += value;
            }
            return totalValue;
        }

        public decimal CalculateBenefit()
        {
            return CalculateTotalFundValue() + basicCoverage; // Simple benefit calculation
        }
    }
}