using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton INSTANCE;
        public readonly string Hello = "Hello";

        //we put the constructor as private because nobody CAN'T create a nem SINGLETON instance
        private Singleton()
        {

        }

        //only for we see that ONLY singleton can create NEW singleton instance
        public static Singleton GetInstance()
        {
            if (INSTANCE != null)
                return INSTANCE;
            INSTANCE = new Singleton();
            return INSTANCE;
        }
    }
}
