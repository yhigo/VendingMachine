using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {

        private Storage _storage = new Storage();
        private CoinMech _coinMech = new CoinMech();

        public Drink Buy(ICoin payment, DrinkType kind)
        {
            if ((payment.Type != CoinType._100YEN) && (payment.Type != CoinType._500YEN))
            {
                _coinMech.AddChange(payment);
                return null;
            }

            if (_storage.isEmpty(kind))
            {
                _coinMech.AddChange(payment);
                return null;
            }

            // 釣り銭不足
            if (payment.Type == CoinType._500YEN && _coinMech.DoesNotHaveChange)
            {
                _coinMech.AddChange(payment);
                return null;
            }

            if (payment.Type == CoinType._100YEN)
            {
                // 100円玉を釣り銭に使える
                _coinMech.AddCoinIntoCashBox(payment);
            }
            else if (payment.Type == CoinType._500YEN)
            {
                // 400円のお釣り
                _coinMech.AddChange(_coinMech.TakeOutChange());
            }

            _storage.Decrement(kind);

            return new Drink(kind);
        }

        public Change Refund()
        {
            return _coinMech.Refund();
        }
    }
}
