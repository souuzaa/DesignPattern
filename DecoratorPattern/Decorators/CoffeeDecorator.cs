using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee _iCoffee;

        public CoffeeDecorator(ICoffee iCoffee)
        {
            _iCoffee = iCoffee;
        }

        public virtual double GetCost()
        {
            return _iCoffee.GetCost();
        }

        public virtual string GetIngredients()
        {
            return _iCoffee.GetIngredients();
        }
    }
}
