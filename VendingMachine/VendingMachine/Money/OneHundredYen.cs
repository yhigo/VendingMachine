using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class OneHundredYen : ICoin
    {
        public Money Money => new Money(100);

        public CoinType Type => CoinType._100YEN;
    }
}
