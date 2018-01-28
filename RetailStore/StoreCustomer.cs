using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    public sealed class StoreCustomer : User
    {
        public StoreCustomer(string name, DateTime joinDate, bool isVip = false) : base(name, joinDate)
        {
            IsVip = isVip;
        }

        public override bool IsEmployee => false;

        public override bool IsAffiliate => false;

        public bool IsVip { get; private set; }
    }
}
