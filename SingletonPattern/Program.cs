using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton: " + Singleton.GetInstance().Hello);
            Console.ReadKey(true);
        }
    }
}