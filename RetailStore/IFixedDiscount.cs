using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public interface IFixedDiscount
    {
        decimal DiscountAppliedForEach { get; }
        decimal DiscountValue { get; }

        decimal ApplyDiscount(decimal billAmount);
    }
}
