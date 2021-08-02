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

            Order order = null;
            if (!this.orders.ContainsKey(prod.ID))
            {
                // Intantiate order and set the Product from param
                order = new Order();
                order.Product = prod;
                // Add product to orders 
                this.orders.Add(prod.ID, order);
            }
            else
            {
                // Get order from dictionary based on product id
                order = this.orders[prod.ID];
            }

            // increment quantity 
            order.Quantity += quantity;
        }

        public string CheckOut()
        {
            StringBuilder msg = new StringBuilder();
            if (this.orders.Count <= 0)
                throw new ApplicationException("Cart is empty");

            HashSet<Action> actions = new HashSet<Action>();

            foreach (Order order in this.orders.Values)
            {
                foreach (Action action in order.Product.Action)
                    actions.Add(action);
            }

            foreach (Action action in actions)
                msg.AppendLine(action.Message);

            return msg.ToString();
        }

    }
}
