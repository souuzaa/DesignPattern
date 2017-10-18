using FacadePattern.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFacade facade = new CarFacade();
            facade.CreateCompleteCar();
            Console.ReadKey(true);
        }
    }
}
