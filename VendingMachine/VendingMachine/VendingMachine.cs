using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {

        private Stock stockOfCoke = new Stock(5);        // コーラの在庫数
        private Stock stockOfDietCoke = new Stock(5);    // ダイエットコーラの在庫数
        private Stock stockOfTea = new Stock(5);         // お茶の在庫数
        private StockOf100Yen stockOf100Yen = new StockOf100Yen(new List<ICoin>(Enumerable.Range(0, 10).Select(i => new OneHundredYen()).ToList()));     // 100円玉の在庫
        private Change change = new Change();             // お釣り

        public Drink Buy(ICoin payment, DrinkType kind)
        {
            if ((payment.Type != CoinType._100YEN) && (payment.Type != CoinType._500YEN))
            {
                change.Add(payment);
                return null;
            }

            if ((kind == DrinkType.COKE) && (stockOfCoke.isEmpty))
            {
                change.Add(payment);
                return null;
            }
            else if ((kind == DrinkType.DIET_COKE) && (stockOfDietCoke.isEmpty))
            {
                change.Add(payment);
                return null;
            }
            else if ((kind == DrinkType.TEA) && (stockOfTea.isEmpty))
            {
                change.Add(payment);
                return null;
            }

            // 釣り銭不足
            if (payment.Type == CoinType._500YEN && stockOf100Yen.DoesNotHaveChange)
            {
                change.Add(payment);
                return null;
            }

            if (payment.Type == CoinType._100YEN)
            {
                // 100円玉を釣り銭に使える
                stockOf100Yen.Push(payment);
            }
            else if (payment.Type == CoinType._500YEN)
            {
                // 400円のお釣り
                change.Add(stockOf100Yen.takeOutChange());
            }

            if (kind == DrinkType.COKE)
            {
                stockOfCoke.Decrement();
            }
            else if (kind == DrinkType.DIET_COKE)
            {
                stockOfDietCoke.Decrement();
            }
            else
            {
                stockOfTea.Decrement();
            }

            return new Drink(kind);
        }

        public Change Refund()
        {
            var result = change.ShallowCopy();
            change.Clear();
            return result;
        }
    }
}
