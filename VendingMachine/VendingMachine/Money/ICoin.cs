using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface ICoin
    {
        public Money Money { get; }
        public CoinType Type { get; }
    }
}
