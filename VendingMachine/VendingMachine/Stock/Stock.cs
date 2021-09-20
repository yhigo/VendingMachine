using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Stock
    {
        private int _quantity;

        public Stock(int quantity)
        {
            _quantity = quantity;
        }

        public bool isEmpty => _quantity == 0;

        public void Decrement()
        {
            _quantity--;
        }
    }
}
