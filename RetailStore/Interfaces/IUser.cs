using System;

namespace RetailStore
{
    public interface IUser
    {
        string Name { get; }
        DateTime JoiningDate { get; }
        bool IsEmployee { get; }
        bool IsAffiliate { get; }
    }
}
