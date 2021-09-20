using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class FiveHundredYen : ICoin
    {
        public Money Money => new Money(500);
        public CoinType Type => CoinType._500YEN;
    }
}
