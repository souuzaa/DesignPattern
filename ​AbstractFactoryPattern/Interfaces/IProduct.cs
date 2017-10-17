using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodPattern.Interfaces
{
    public interface IProduct
    {
        string GetName();
        void SetPrice(double price);
        double GetPrice();
    }
}
