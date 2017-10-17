using FactoryMethodPattern.Factory;
using FactoryMethodPattern.Interfaces;
using FactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            ProductAbstractFactory[] factory = new ProductAbstractFactory[2];
            factory[0] = new PhoneConcreteFactory();
            factory[1] = new TabletConcreteFactory();

            foreach(ProductAbstractFactory item in factory)
            {
                IProduct product = item.SetPrice();
                Console.WriteLine(string.Format("Type: {0}; Description: {1}; Price {2:C2}", 
                    product.GetType().Name,
                    product.GetName(), 
                    product.GetPrice()));
            }

            Console.ReadKey(true);
        }
    }
}
