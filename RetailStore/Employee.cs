using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class Employee: User
    {
        public Employee(string name, DateTime joinDate, Employee manager = null) : base(name, joinDate)
        {
            Manager = manager;
        }

        public override bool IsEmployee => true;

        public override bool IsAffiliate => false;

        public Employee Manager { get; private set; }
    }
}
