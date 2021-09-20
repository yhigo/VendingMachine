﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class StockOf100Yen
    {
        private Stack<ICoin> _stock = new Stack<ICoin>();

        public StockOf100Yen(List<ICoin> coins)
        {
            _stock = new Stack<ICoin>(coins);
        }
        public int Count => _stock.Count;

        public void Push(ICoin coin) => _stock.Push(coin);

        public ICoin Pop() => _stock.Pop();
    }
}
