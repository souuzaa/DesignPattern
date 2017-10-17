using StrategyPattern.Strategies;
using System;

namespace StrategyPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Minus strategy
            CalculateClient client = new CalculateClient(new Minus());
            Console.WriteLine("Minus: " + client.Calculate(7, 1));

            //Plus strategy
            client = new CalculateClient(new Plus());
            Console.WriteLine("Plus: " + client.Calculate(7, 1));

            //for ready console output
            Console.ReadKey(true);
        }
    }
}
