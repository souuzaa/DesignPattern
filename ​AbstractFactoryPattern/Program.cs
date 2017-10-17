using AbstractMethodPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodPattern.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductAbstractFactory factory = new ProductConcreteFactory();

            IProduct product = factory.SetPhonePrice();
            Console.WriteLine(string.Format("Type: {0}; Description: {1}; Price {2:C2}",
                   product.GetType().Name,
                   product.GetName(),
                   product.GetPrice()));

            product = factory.SetTabletPrice();
            Console.WriteLine(string.Format("Type: {0}; Description: {1}; Price {2:C2}",
                   product.GetType().Name,
                   product.GetName(),
                   product.GetPrice()));

            Console.ReadKey(true);
        }
    }
}
