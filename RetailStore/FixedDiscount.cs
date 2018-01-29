using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class FixedDiscount : IFixedDiscount
    {                
        public const int DISCOUNT_APPLIED_OF_EACH = 100;
        public const decimal DISCOUNT_VALUE = 5;
        
        public FixedDiscount()
        {           
        }

        public decimal ApplyDiscount(decimal billAmount)
        {
            return ((int)(billAmount / DISCOUNT_APPLIED_OF_EACH)) * DISCOUNT_VALUE;
        }
    }
}
