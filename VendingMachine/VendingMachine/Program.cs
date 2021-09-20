using System;
using System.Linq;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendincMachine = new VendingMachine();

            var drink = vendincMachine.Buy(new FiveHundredYen(), DrinkType.COKE);
            var charge = vendincMachine.Refund();

            if (drink != null && drink.IsCoke)
            {
                Console.WriteLine("buy coke");
                Console.WriteLine($"charge is {charge.Money} yen");
            }
            else
            {
                Console.WriteLine("you could not buy a coke");
            }
        }
    }
}
