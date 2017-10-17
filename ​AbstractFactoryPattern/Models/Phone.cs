using AbstractMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodPattern.Models
{
    public class Phone : IProduct
    {
        private double _price;
        public string GetName()
        {
            return "Apple Iphone 8";
        }

        public void SetPrice(double price)
        {
            this._price = price;
        }

        public double GetPrice()
        {
            return this._price;
        }
    }
}
