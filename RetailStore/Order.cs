using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RetailStore
{
    public class Order : IOrder
    {
        protected List<IOrderItem> orderItems;

        private Order()
        { }

        public Order(IUser customer)
        {
            Customer = customer;

            OrderNumber = Guid.NewGuid().ToString();
            OrderDate = DateTime.UtcNow;

            orderItems = new List<IOrderItem>();
        }

        public string OrderNumber { get; protected set; }

        public DateTime OrderDate { get; protected set; }

        public virtual decimal GroceriesAmount
        {
            get
            {
                var orders = from o in this
                             where o.Product.ProductType.IsGrocery
                             select o;

                return orders.Sum(o => o.TotalPrice);
            }
        }

        public virtual decimal NonGroceriesAmount
        {
            get
            {
                return this.Where(o => !o.Product.ProductType.IsGrocery).Sum(o => o.TotalPrice);
            }
        }

        public IUser Customer { get; protected set; }

        public virtual void AddItem(IOrderItem item)
        {
            orderItems.Add(item);
        }

        public virtual void RemoveItem(IOrderItem item)
        {
            orderItems.Remove(item);
        }

        public virtual IEnumerator<IOrderItem> GetEnumerator()
        {
            return orderItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
