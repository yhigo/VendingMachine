﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Change
    {
        private List<ICoin> _coins = new List<ICoin>();

        public Change()
        {

        }

        public Change(List<ICoin> coins)
        {
            _coins = new List<ICoin>(coins);
        }

        public void Add(ICoin coin) => _coins.Add(coin);

        public void Add(Change change) => _coins.AddRange(change._coins);

        public int Amount => _coins.Sum(coin => coin.Amount);

        public void Clear() => _coins.Clear();

        public Change ShallowCopy() => new(_coins);
    }
}
