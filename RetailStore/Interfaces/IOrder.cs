using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public interface IOrder : IEnumerable<IOrderItem>
    {
        string OrderNumber { get; }
        DateTime OrderDate { get; }
        decimal GroceriesAmount { get; }
        decimal NonGroceriesAmount { get; }
        IUser Customer { get; }

        void AddItem(IOrderItem item);
        void RemoveItem(IOrderItem item);
    }
}
