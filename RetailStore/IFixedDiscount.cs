using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public interface IFixedDiscount
    {        
        decimal ApplyDiscount(decimal billAmount);
    }
}
