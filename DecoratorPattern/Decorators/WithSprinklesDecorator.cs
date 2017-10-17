using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class WithSprinklesDecorator : CoffeeDecorator
    {
        public WithSprinklesDecorator(ICoffee iCoffee) : base(iCoffee)   
        {
            
        }

        // Overriding methods defined in the abstract superclass
        public override double GetCost()
        { 
            return base.GetCost() + 0.2;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + ", Sprinkles";
        }
    }
}
