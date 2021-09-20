using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Storage
    {
        private Dictionary<DrinkType, Stock> _stocks = new Dictionary<DrinkType, Stock>()
        {
            { DrinkType.COKE, new Stock(5) },
            { DrinkType.DIET_COKE, new Stock(5) },
            { DrinkType.TEA, new Stock(5) },
        };

        public bool isEmpty(DrinkType type) => _stocks[type].isEmpty;

        private void Decrement(DrinkType type)
        {
            _stocks[type].Decrement();
        }

        public Drink TakeOut(DrinkType kind)
        {
            Decrement(kind);
            return new Drink(kind);
        }
    }
}
