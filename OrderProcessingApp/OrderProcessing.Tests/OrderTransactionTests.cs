using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Tests
{
    [TestClass()]
    public class OrderTransactionTests
    {
        [TestMethod()]
        // Single Order
        public void AddToCartTest_Success01()
        {
            OrderTransaction trans = new OrderTransaction();
            trans.AddToCart(null, 0);
        }

        [TestMethod()]
        // Multiple Orders
        public void AddToCartTest_Success02()
        {
            OrderTransaction trans = new OrderTransaction();
            Product p = new Product();
            trans.AddToCart(p, 0);
        }

        [TestMethod()]
        // No orders specified
        public void AddToCartTest_Fail01()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CheckOutTest_Success01()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CheckOutTest_Fail01()
        {
            Assert.Fail();
        }
    }
}