using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public interface IPercentageDiscount
    {
        decimal DiscountForEmployee { get; }
        decimal DiscountForAffiliate { get; }
        decimal DiscountForCustomer { get; }
        int CustomerLoyaltyMinimumYears { get; }

        decimal ApplyDiscount(IOrder order);
    }
}
