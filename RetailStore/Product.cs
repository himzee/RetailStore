using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public abstract class Product : IProduct
    {
        private Product()
        { }

        public Product(string name, IProductType productType)
        {
            Name = name;
            ProductType = productType;
        }

        public string Name { get; protected set; }

        public IProductType ProductType { get; protected set; }

        public decimal Price { get; protected set; }

        public int AvailableStock { get; protected set; }

        protected virtual void ChangePrice(decimal newPrice)
        {
            Price = newPrice;
        }

        protected virtual void AddToStock(int quantity)
        {
            AvailableStock += quantity;
        }

        protected virtual void Dispense(int quantity)
        {
            AvailableStock -= quantity;
        }
    }
}
