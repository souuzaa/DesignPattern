using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CalculateClient
    {
        private ICalculate Strategy { get; set; }

        public CalculateClient(ICalculate strategy)
        {
            Strategy = strategy;
        }

        //Executes the strategy
        public int Calculate(int value1, int value2)
        {
            return Strategy.Calculate(value1, value2);
        }
    }
}
