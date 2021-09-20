using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Drink
    {
        private DrinkType _kind;

        public Drink(DrinkType kind)
        {
            this._kind = kind;
        }

        public bool IsCoke => _kind == DrinkType.COKE;
        public bool IsDietCoke => _kind == DrinkType.DIET_COKE;
        public bool IsTea => _kind == DrinkType.TEA;
    }
}
