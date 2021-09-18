using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendincMachine = new VendingMachine();

            var drink = vendincMachine.Buy(500, Drink.COKE);
            var charge = vendincMachine.Refund();

            if (drink != null && drink.Kind == Drink.COKE)
            {
                Console.WriteLine("buy coke");
                Console.WriteLine($"charge is {charge} yen");
            }
            else
            {
                Console.WriteLine("you could not buy a coke");
            }
        }
    }
}
