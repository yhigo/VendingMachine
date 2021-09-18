using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {

        private int stockOfCoke = 5;        // コーラの在庫数
        private int stockOfDietCoke = 5;    // ダイエットコーラの在庫数
        private int stockOfTea = 5;         // お茶の在庫数
        private int stockOf100Yen = 10;     // 100円玉の在庫
        private int charge = 0;             // お釣り

        public Drink Buy(int money, int kindOfDrink)
        {
            if ((money != 100) && (money != 500))
            {
                charge += money;
                return null;
            }

            if ((kindOfDrink == Drink.COKE) && (stockOfCoke == 0))
            {
                charge += money;
                return null;
            }
            else if ((kindOfDrink == Drink.DIET_COKE) && (stockOfDietCoke == 0))
            {
                charge += money;
                return null;
            }
            else if ((kindOfDrink == Drink.TEA) && (stockOfTea == 0))
            {
                charge += money;
                return null;
            }

            // 釣り銭不足
            if (money == 500 && stockOf100Yen < 4)
            {
                charge += money;
                return null;
            }

            if (money == 100)
            {
                // 100円玉を釣り銭に使える
                stockOf100Yen++;
            }
            else if (money == 500)
            {
                // 400円のお釣り
                charge += (money - 100);
                // 100円玉を釣り銭に使える
                stockOf100Yen -= (money - 100) / 100;
            }

            if (kindOfDrink == Drink.COKE)
            {
                stockOfCoke--;
            }
            else if (kindOfDrink == Drink.DIET_COKE)
            {
                stockOfDietCoke--;
            }
            else
            {
                stockOfTea--;
            }

            return new Drink(kindOfDrink);
        }

        public int Refund()
        {
            int result = charge;
            charge = 0;
            return result;
        }
    }
}
