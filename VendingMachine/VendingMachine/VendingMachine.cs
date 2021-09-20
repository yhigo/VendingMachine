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

            _coinMech.Put(payment);

            // 釣り銭不足
            if (_coinMech.DoesNotHaveChange)
            {
                return null;
            }

            // 在庫切れ
            if (_storage.isEmpty(kind))
            {
                return null;
            }

            _coinMech.Commit();

            return _storage.TakeOut(kind);
        }

        public Change Refund()
        {
            return _coinMech.Refund();
        }
    }
}
