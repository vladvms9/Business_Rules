using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class OrderTransaction
    {
        private Dictionary<int, Order> orders;

        public Dictionary<int, Order> Order
        {
            get { return this.orders; }
        }


        public OrderTransaction()
        {
            this.orders = new Dictionary<int, Order>();
        }

        /// <summary>
        /// AddToCart
        /// To simulate multiple orders with same product, a quantity param is introduced.
        /// </summary>
        /// <param name="prod">Product</param>
        /// <param name="quantity">Quantity</param>
        public void AddToCart(Product prod, int quantity)
        {
            if (prod == null || quantity <= 0)
                throw new ApplicationException("Invalid product or quantity.");

        }

        public string CheckOut()
        {
            throw new NotImplementedException();
        }

    }
}
