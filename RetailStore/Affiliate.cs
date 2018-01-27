using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class Affiliate: User
    {
        public Affiliate(string name, DateTime joinDate, string companyName = null) : base(name, joinDate)
        {
            CompanyName = companyName;
        }
        public override bool IsEmployee => false;

        public override bool IsAffiliate => true;

        public string CompanyName { get; private set; }
    }
}
