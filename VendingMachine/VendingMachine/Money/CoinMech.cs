using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class CoinMech
    {
        private CashBox _cashBox = new CashBox(new List<ICoin>(Enumerable.Range(0, 10).Select(i => new OneHundredYen()).ToList()));     // 100円玉の在庫

        private Payment _payment;

        public void Put(ICoin coin)
        {
            _payment = new Payment(coin);
        }

        public bool DoesNotHaveChange => _payment.NeedChange && _cashBox.DoesNotHaveChange;

        public Change TakeOutChange()
        {
            return _cashBox.TakeOutChange();
        }

        public Change Refund()
        {
            return _payment.Refund();
        }

        public void Commit()
        {
            _payment.Commit(_cashBox);
        }
    }
}
