using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class PercentageDiscount : IPercentageDiscount
    {        
        public const int CUSTOMER_LOYALTY_MINIMUM_YEARS = 2;
        public const decimal DISCOUNT_FOR_CUSTOMERS = 0.05m;
        public const decimal DISCOUNT_FOR_AFFILIATE = 0.1m;
        public const decimal DISCOUNT_FOR_EMPLOYEE = 0.3m;

        public PercentageDiscount()
        {
            
        }

        public decimal ApplyDiscount(IOrder order)
        {
            if (order.Customer.IsEmployee)
            {
                return order.NonGroceriesAmount * DISCOUNT_FOR_EMPLOYEE;
            }
            else if (order.Customer.IsAffiliate)
            {
                return order.NonGroceriesAmount * DISCOUNT_FOR_AFFILIATE;
            }
            else if (DateTime.UtcNow.Date >= order.Customer.JoiningDate.AddYears(CUSTOMER_LOYALTY_MINIMUM_YEARS).ToUniversalTime().Date)
            {
                return order.NonGroceriesAmount * DISCOUNT_FOR_CUSTOMERS;
            }

            return 0;
        }
    }
}
