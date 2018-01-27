using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class PercentageDiscount : IPercentageDiscount
    {
        private static readonly Lazy<PercentageDiscount> defaultCalc = new Lazy<PercentageDiscount>(() => new PercentageDiscount());

        public static PercentageDiscount Instance => defaultCalc.Value;

        public decimal DiscountForEmployee { get; private set; }

        public decimal DiscountForAffiliate { get; private set; }

        public decimal DiscountForCustomer { get; private set; }

        public int CustomerLoyaltyMinimumYears { get; private set; }

        private PercentageDiscount()
        {
            DiscountForEmployee = 0.3m;
            DiscountForAffiliate = 0.1m;
            DiscountForCustomer = 0.05m;
            CustomerLoyaltyMinimumYears = 2;
        }

        public decimal ApplyDiscount(IOrder order)
        {
            if (order.Customer.IsEmployee)
            {
                return order.NonGroceriesAmount * DiscountForEmployee;
            }
            else if (order.Customer.IsAffiliate)
            {
                return order.NonGroceriesAmount * DiscountForAffiliate;
            }
            else if (DateTime.UtcNow.Date >= order.Customer.JoiningDate.AddYears(CustomerLoyaltyMinimumYears).ToUniversalTime().Date)
            {
                return order.NonGroceriesAmount * DiscountForCustomer;
            }

            return 0;
        }
    }
}
