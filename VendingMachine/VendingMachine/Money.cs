using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Money
    {
        private int _amount;

        public Money(int amount)
        {
            _amount = amount;
        }

        public Money Add(Money money)
        {
            return new Money(_amount + money._amount);
        }

        public override string ToString()
        {
            return _amount.ToString();
        }
    }
}
