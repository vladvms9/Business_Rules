using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Action> Action { get; set; }

        public Product()
        {
            this.Action = new List<Action>();
        }
    }
}
