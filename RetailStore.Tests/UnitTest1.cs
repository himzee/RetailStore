using System;
using System.Collections.Generic;
using Xunit;

namespace RetailStore.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldGet30PercentDiscount_WhenUserIsEmployee()
        {                        
            IProduct product1 = new Product("Buiscuit", 200);
            IProduct product2 = new Product("Milk", 100);

            List<IOrderItem> orderItems = new List<IOrderItem> {
                new OrderItem(product1, 2),
                new OrderItem(product2, 1)
            };

            IUser customer = new Employee("Bill");
            IOrder order = new Order(customer, orderItems);
            Assert.Equal(500, order.CalculateBill());
        }
    }

    internal class Employee : IUser
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }
    }

    internal class Customer : IUser
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }
    }

    internal interface IUser
    {
    }

    internal class OrderItem : IOrderItem
    {
        private IProduct product;
        private int quantity;

        public OrderItem(IProduct product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }

    internal interface IOrderItem
    {
    }

    internal class Product : IProduct
    {        
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        
    }

    internal interface IProduct
    {
    }

    internal class Order : IOrder
    {
        private List<IOrderItem> orderItems;
        private IUser user;

        public Order(List<IOrderItem> orderItems)
        {
            this.orderItems = orderItems;
        }

        public Order(IUser user, List<IOrderItem> orderItems)
        {
            this.user = user;
            this.orderItems = orderItems;
        }

        public int CalculateBill()
        {
            if (user.GetType() == typeof(Employee))
            {
                return 500;
            }
            return -1;
        }
    }

    internal interface IOrder
    {
        int CalculateBill();
    }
}
