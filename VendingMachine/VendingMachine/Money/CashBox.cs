using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class CashBox
    {
        private StockOf100Yen _stockOf100Yen;

        public CashBox(List<ICoin> coins)
        {
            _stockOf100Yen = new StockOf100Yen(coins);
        }

        public bool DoesNotHaveChange => _stockOf100Yen.DoesNotHaveChange;

        public void Add(ICoin coin)
        {
            _stockOf100Yen.Push(coin);
        }

        public Change TakeOutChange() => _stockOf100Yen.takeOutChange();
    }
}
