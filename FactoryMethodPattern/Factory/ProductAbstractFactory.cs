using FactoryMethodPattern.Interfaces;
using FactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factory
{
    public abstract class ProductAbstractFactory
    {
        public abstract IProduct SetPrice();
    }
}
