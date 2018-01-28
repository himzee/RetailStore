using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore.Tests
{
    static class TestData
    {        
        public static List<IOrderItem> Products
        {
            get;
            private set;
        }

        public static List<IUser> Users
        {
            get;
            private set;
        }

        static TestData()
        {
            Products = GetProductsCatalog();
            Users = Getusers();
        }

        private static List<IOrderItem> GetProductsCatalog()
        {
            var productsCat = new List<IOrderItem>
            {
                new OrderItem(new OtherProduct("P1")),
                new OrderItem(new Food("P2")),
                new OrderItem(new Food("P3")),
                new OrderItem(new OtherProduct("P4")),
                new OrderItem(new OtherProduct("P5")),
                new OrderItem(new Food("P6")),
                new OrderItem(new OtherProduct("P7")),
                new OrderItem(new Food("P8")),
                new OrderItem(new OtherProduct("P9")),
                new OrderItem(new OtherProduct("P10")),
                new OrderItem(new OtherProduct("P11")),
                new OrderItem(new OtherProduct("P12")),
                new OrderItem(new Food("P13")),
                new OrderItem(new Food("P14")),
                new OrderItem(new OtherProduct("P15")),
                new OrderItem(new OtherProduct("P16")),
                new OrderItem(new OtherProduct("P17")),
                new OrderItem(new OtherProduct("P18")),
                new OrderItem(new OtherProduct("P19")),
                new OrderItem(new OtherProduct("P20"))
            };

            return productsCat;
        }

        private static List<IUser> Getusers()
        {
            var users = new List<IUser>
            {
                new Employee("U1",DateTime.UtcNow.AddMonths(-12)),
                new Affiliate("U2", DateTime.UtcNow.AddMonths(-18)),
                new StoreCustomer("U3", DateTime.UtcNow.AddMonths(-12)),
                new StoreCustomer("U4", DateTime.UtcNow.AddMonths(-24)),
                new StoreCustomer("U5", DateTime.UtcNow.AddMonths(-24).AddDays(-1)),
                new StoreCustomer("U6", DateTime.UtcNow.AddMonths(-24).AddDays(1)),
                new StoreCustomer("U7", DateTime.UtcNow.AddYears(-3))
            };

            return users;
        }
    }
}
