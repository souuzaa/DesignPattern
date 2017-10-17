using AbstractMethodPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractMethodPattern.Interfaces;
using AbstractMethodPattern.Models;

namespace AbstractMethodPattern.Factory
{
    public class ProductConcreteFactory : ProductAbstractFactory
    {
        public override IProduct SetPhonePrice()
        {
            IProduct product = new Phone();
            product.SetPrice(1000);
            return product;
        }

        public override IProduct SetTabletPrice()
        {
            IProduct product = new Tablet();
            product.SetPrice(500);
            return product;
        }
    }
}
