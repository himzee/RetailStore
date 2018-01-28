using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    public abstract class ProductType : IProductType
    {
        private ProductType()
        { }

        public ProductType(string name, bool isGrocery = false)
        {
            Name = name;
            IsGrocery = isGrocery;
        }

        public string Name { get; protected set; }

        public bool IsGrocery { get; protected set; }
    }
}
