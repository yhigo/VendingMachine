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

        private Change _change = new Change();

        public void AddChange(ICoin payment) => _change.Add(payment);

        public void AddChange(Change change) => _change.Add(change);

        public void AddCoinIntoCashBox(ICoin payment) => _cashBox.Add(payment);

        public bool DoesNotHaveChange => _cashBox.DoesNotHaveChange;

        public Change TakeOutChange()
        {
            return _cashBox.TakeOutChange();
        }

        public Change Refund()
        {
            var result = _change.ShallowCopy();
            _change.Clear();
            return result;
        }
    }
}
