using DecoratorPattern.Decorators;
using DecoratorPattern.Interfaces;
using DecoratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICoffee coffee = new SimpleCoffee();
            Print(coffee);

            coffee = new WithMilkDecorator(coffee);
            Print(coffee);

            coffee = new WithSprinklesDecorator(coffee);
            Print(coffee);

            Console.ReadKey(true);
        }

        public static void Print(ICoffee iCoffee)
        {
            Console.WriteLine(String.Format("Cost: {0:N2}; Ingredients: {1}", iCoffee.GetCost(), iCoffee.GetIngredients()));
        }
    }
}
