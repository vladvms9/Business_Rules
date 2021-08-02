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
        List<Action> actions;
        List<Product> products;

        [TestInitialize]
        public void TestInitialize()
        {
            this.actions = new List<Action>();
            this.actions.Add(new Action() { ID = 1, Message = "generate a packing slip for shipping" });
            this.actions.Add(new Action() { ID = 2, Message = "create a duplicate packing slip for the royalty department" });
            this.actions.Add(new Action() { ID = 3, Message = "generate a commission payment to the agent" });
            this.actions.Add(new Action() { ID = 4, Message = "activate that membership" });
            this.actions.Add(new Action() { ID = 5, Message = "apply the upgrade" });
            this.actions.Add(new Action() { ID = 6, Message = "e-mail the owner and inform them of the activation/upgrade." });
            this.actions.Add(new Action() { ID = 7, Message = "add a free “First Aid” video to the packing slip" });

            this.products = new List<Product>();
            // NO Actions
            products.Add(new Product() { ID = 1, Name = "Physical Product", Action = new List<Action>() { this.actions[0], this.actions[2] } });
            products.Add(new Product() { ID = 2, Name = "Book", Action = new List<Action>() { this.actions[1], this.actions[2] } });
            products.Add(new Product() { ID = 3, Name = "New Membership", Action = new List<Action>() { this.actions[3], this.actions[5] } });
            products.Add(new Product() { ID = 4, Name = "Upgrade Membership", Action = new List<Action>() { this.actions[4], this.actions[5] } });
            products.Add(new Product() { ID = 5, Name = "Video", Action = new List<Action>() { this.actions[6] } });

        }

        [TestMethod()]
        // Single Order
        public void AddToCartTest_Success01()
        {
            // Arrange
            OrderTransaction trans = new OrderTransaction();


            // Act
            trans.AddToCart(this.products[0], 1);

            // Assert
            Assert.AreEqual(1, trans.Order.Count);
        }

        [TestMethod()]
        // Multiple Orders
        public void AddToCartTest_Success02()
        {
            // Arrange
            OrderTransaction trans = new OrderTransaction();


            // Act
            trans.AddToCart(this.products[0], 1);
            trans.AddToCart(this.products[2], 1);

            // Assert
            Assert.AreEqual(2, trans.Order.Count);
        }

        [TestMethod()]
        // No orders specified
        public void AddToCartTest_Fail01()
        {
            // Arrange
            OrderTransaction trans = new OrderTransaction();


            // Act & Assert
            Assert.ThrowsException<ApplicationException>(() => trans.AddToCart(null, 0));
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