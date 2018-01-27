using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public interface IProductType
    {
        string Name { get; }
        bool IsGrocery { get; }
    }
}
