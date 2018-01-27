using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class OrderItem : IOrderItem
    {
        private OrderItem()
        { }

        public OrderItem(IProduct product, int saleQuantity = 1)
        {
            Product = product;
            ItemQuantity = saleQuantity;
        }

        public IProduct Product { get; private set; }

        public int ItemQuantity { get; private set; }

        public decimal TotalPrice => Product.Price * ItemQuantity;
    }
}
