using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    public sealed class Food : Product
    {
        public Food(string name) : base(name, new Grocery())
        {
            Price = 100;
            AvailableStock = 230;
        }
    }
}
