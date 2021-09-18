using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Drink
    {
        public static readonly int COKE = 0;
        public static readonly int DIET_COKE = 1;
        public static readonly int TEA = 2;

        private int _kind;

        public int Kind
        {
            get { return _kind; }
        }


        public Drink(int kind)
        {
            this._kind = kind;
        }
    }
}
