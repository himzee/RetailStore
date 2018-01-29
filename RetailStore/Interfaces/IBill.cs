
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public interface IBill
    {
        string BillNumber { get; }
        DateTime BillDate { get; }
        IOrder Order { get; }
        decimal BillAmount { get; }
    }
}
