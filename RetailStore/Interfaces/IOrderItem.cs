using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public interface IOrderItem
    {
        IProduct Product { get; }
        int ItemQuantity { get; }
        decimal TotalPrice { get; }
    }
}
