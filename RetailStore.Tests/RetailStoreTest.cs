using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailStore;
using Xunit;

namespace RetailStore.Tests
{
    public class RetailStoreTest
    {
        private BillCalculator billCalculator;

        public RetailStoreTest()
        {
            billCalculator = new BillCalculator(new PercentageDiscount(), new FixedDiscount()); 
        }

        [Fact]
        public void UserIsEmployeeWithMixOfProducts()
        {
            var customer = TestData.Users[0];
            var order = new Order(customer);

            order.AddItem(TestData.Products[0]);
            order.AddItem(TestData.Products[1]);
            order.AddItem(TestData.Products[2]);
            order.AddItem(TestData.Products[3]);
            order.AddItem(TestData.Products[4]);

            var bill = new Bill(order);            
            Assert.Equal(390, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsEmployeeWithGroceriesOnly()
        {
            var customer = TestData.Users[0];
            var order = new Order(customer);

            order.AddItem(TestData.Products[1]);
            order.AddItem(TestData.Products[2]);

            var bill = new Bill(order);            
            Assert.Equal(190, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsEmployeeWithNoGroceries()
        {
            var customer = TestData.Users[0];
            var order = new Order(customer);

            order.AddItem(TestData.Products[0]);
            order.AddItem(TestData.Products[3]);
            order.AddItem(TestData.Products[4]);

            var bill = new Bill(order);
            
            Assert.Equal(200, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsAffiliateWithMixOfProducts()
        {
            var customer = TestData.Users[1];
            var order = new Order(customer);

            order.AddItem(TestData.Products[0]);
            order.AddItem(TestData.Products[1]);
            order.AddItem(TestData.Products[2]);
            order.AddItem(TestData.Products[3]);
            order.AddItem(TestData.Products[4]);

            var bill = new Bill(order);
            Assert.Equal(450, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsAffiliateWithGroceriesOnly()
        {
            var customer = TestData.Users[1];
            var order = new Order(customer);

            order.AddItem(TestData.Products[1]);
            order.AddItem(TestData.Products[2]);

            var bill = new Bill(order);            
            Assert.Equal(190, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsAffiliateWithNoGroceries()
        {
            var customer = TestData.Users[1];
            var order = new Order(customer);

            order.AddItem(TestData.Products[0]);
            order.AddItem(TestData.Products[3]);
            order.AddItem(TestData.Products[4]);

            var bill = new Bill(order);            
            Assert.Equal(260, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForLessThanTwoYearsWithMixOfProducts()
        {
            var customer = TestData.Users[2];
            var order = new Order(customer);

            order.AddItem(TestData.Products[0]);
            order.AddItem(TestData.Products[1]);
            order.AddItem(TestData.Products[2]);
            order.AddItem(TestData.Products[3]);
            order.AddItem(TestData.Products[4]);

            var bill = new Bill(order);            
            Assert.Equal(475, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForLessThanTwoYearsWithGroceriesOnly()
        {
            var customer = TestData.Users[2];
            var order = new Order(customer);

            order.AddItem(TestData.Products[1]);
            order.AddItem(TestData.Products[2]);

            var bill = new Bill(order);            
            Assert.Equal(190, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForLessThanTwoYearsWithNoGroceries()
        {
            var customer = TestData.Users[2];
            var order = new Order(customer);

            order.AddItem(TestData.Products[0]);
            order.AddItem(TestData.Products[3]);
            order.AddItem(TestData.Products[4]);

            var bill = new Bill(order);            
            Assert.Equal(285, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForJustTwoYearsWithMixOfProducts()
        {
            var customer = TestData.Users[5];
            var order = new Order(customer);

            order.AddItem(TestData.Products[0]);
            order.AddItem(TestData.Products[1]);
            order.AddItem(TestData.Products[2]);
            order.AddItem(TestData.Products[3]);
            order.AddItem(TestData.Products[4]);

            var bill = new Bill(order);            
            Assert.Equal(475, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForJustTwoYearsWithGroceriesOnly()
        {
            var customer = TestData.Users[5];
            var order = new Order(customer);

            order.AddItem(TestData.Products[1]);
            order.AddItem(TestData.Products[2]);

            var bill = new Bill(order);            
            Assert.Equal(190, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForJustTwoYearsWithNoGroceries()
        {
            var customer = TestData.Users[5];
            var order = new Order(customer);

            order.AddItem(TestData.Products[0]);
            order.AddItem(TestData.Products[3]);
            order.AddItem(TestData.Products[4]);

            var bill = new Bill(order);            
            Assert.Equal(285, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForMoreThanTwoYearsWithMixOfProducts()
        {
            var customer = TestData.Users[6];
            var order = new Order(customer);

            order.AddItem(TestData.Products[0]);
            order.AddItem(TestData.Products[1]);
            order.AddItem(TestData.Products[2]);
            order.AddItem(TestData.Products[3]);
            order.AddItem(TestData.Products[4]);

            var bill = new Bill(order);
            Assert.Equal(465, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForMoreThanTwoYearsWithGroceriesOnly()
        {
            var customer = TestData.Users[6];
            var order = new Order(customer);

            order.AddItem(TestData.Products[1]);
            order.AddItem(TestData.Products[2]);

            var bill = new Bill(order);            
            Assert.Equal(190, billCalculator.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForMoreThanTwoYearsWithNoGroceries()
        {
            var customer = TestData.Users[6];
            var order = new Order(customer);

            order.AddItem(TestData.Products[0]);
            order.AddItem(TestData.Products[3]);
            order.AddItem(TestData.Products[4]);

            var bill = new Bill(order);            
            Assert.Equal(275, billCalculator.CalculateNetPayableAmount(bill));
        }
    }
}
