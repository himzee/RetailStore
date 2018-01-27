using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class Bill : IBill
    {
        private Bill()
        { }

        public Bill(IOrder order)
        {
            Order = order;

            BillNumber = Guid.NewGuid().ToString();
            BillDate = DateTime.UtcNow;
        }

        public string BillNumber { get; protected set; }

        public DateTime BillDate { get; protected set; }

        public IOrder Order { get; protected set; }

        public virtual decimal BillAmount => Order.GroceriesAmount + Order.NonGroceriesAmount;
    }
}
