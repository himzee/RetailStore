using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public interface IPercentageDiscount
    {       
        decimal ApplyDiscount(IOrder order);
    }
}
