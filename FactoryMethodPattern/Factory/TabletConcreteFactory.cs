using FactoryMethodPattern.Interfaces;
using FactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factory
{
    public class TabletConcreteFactory : ProductAbstractFactory
    {
        public override IProduct SetPrice()
        {
            IProduct product = new Tablet();
            product.SetPrice(500);
            return product;
        }
    }
}
