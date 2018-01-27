using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public abstract class User : IUser
    {
        private User()
        { }

        public User(string name, DateTime joinDate)
        {
            Name = name;
            JoiningDate = joinDate;
        }

        public string Name { get; protected set; }

        public DateTime JoiningDate { get; protected set; }

        public abstract bool IsEmployee { get; }

        public abstract bool IsAffiliate { get; }
    }
}
