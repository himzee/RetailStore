using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public interface IBillCalculator
    {
        decimal CalculateNetPayableAmount(IBill bill);

        IFixedDiscount FixedDiscountCalculator { get; }
        IPercentageDiscount PercentageDiscountCalculator { get; }
    }
}
