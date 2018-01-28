using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class FixedDiscount : IFixedDiscount
    {        
        public decimal DiscountAppliedForEach { get; private set; }

        public decimal DiscountValue { get; private set; }

        public FixedDiscount()
        {
            DiscountAppliedForEach = 100;
            DiscountValue = 5;
        }

        public decimal ApplyDiscount(decimal billAmount)
        {
            return ((int)(billAmount / DiscountAppliedForEach)) * DiscountValue;
        }
    }
}
