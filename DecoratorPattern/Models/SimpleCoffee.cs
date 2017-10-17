using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Models
{
    public class SimpleCoffee : ICoffee
    {
        public double GetCost()
        {
            return 1;
        }

        public string GetIngredients()
        {
            return "Coffee";
        }
    }
}
