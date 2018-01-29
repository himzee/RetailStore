using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public interface IProduct
    {
        string Name { get; }
        IProductType ProductType { get; }
        decimal Price { get; }
        int AvailableStock { get; }
    }
}
