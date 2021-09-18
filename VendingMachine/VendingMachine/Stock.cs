using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Stock
    {
        public int Quantity { get; private set; }

        public Stock(int quantity)
        {
            Quantity = quantity;
        }

        public void Decrement()
        {
            Quantity--;
        }
    }
}
