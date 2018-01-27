using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class BillCalculator : IBillCalculator
    {
        public IFixedDiscount FixedDiscountCalculator { get; private set; }

        public IPercentageDiscount PercentageDiscountCalculator { get; private set; }

        public BillCalculator(IPercentageDiscount percentageDiscountCalculator, IFixedDiscount fixedDiscountCalculator)
        {
            FixedDiscountCalculator = fixedDiscountCalculator;
            PercentageDiscountCalculator = percentageDiscountCalculator;
        }

        public decimal CalculateNetPayableAmount(IBill bill)
        {
            var percentageDiscount = PercentageDiscountCalculator.ApplyDiscount(bill.Order);
            var fixedDiscount = FixedDiscountCalculator.ApplyDiscount(bill.BillAmount - percentageDiscount);

            return bill.BillAmount - percentageDiscount - fixedDiscount;
        }
    }
}
