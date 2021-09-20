using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Payment
    {
        private Change _change;
        private ICoin _coin;

        public Payment(ICoin coin)
        {
            _coin = coin;
        }

        public bool NeedChange => _coin.Type == CoinType._500YEN;

        public bool IsNotCommited => _coin != null;

        public void Commit(CashBox cashBox)
        {
            if (_coin.Type == CoinType._100YEN)
            {
                cashBox.Add(_coin);
                _change = new Change();
            }

            if (_coin.Type == CoinType._500YEN)
            {
                _change = cashBox.TakeOutChange();
            }

            _coin = null;
        }

        public Change Refund()
        {
            return IsNotCommited ? new Change(_coin) : _change;
        }
    }
}
