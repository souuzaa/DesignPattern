using AbstractMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodPattern.Factory
{
    public abstract class ProductAbstractFactory
    {
        public abstract IProduct SetPhonePrice();
        public abstract IProduct SetTabletPrice();
    }
}
