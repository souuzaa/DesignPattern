using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Interfaces;
using FactoryMethodPattern.Models;

namespace FactoryMethodPattern.Factory
{
    public class PhoneConcreteFactory : ProductAbstractFactory
    {
        public override IProduct SetPrice()
        {
            IProduct product = new Phone();
            product.SetPrice(1000);
            return product;
        }
    }
}
