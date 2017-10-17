using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern​​
{
    class Program
    {
        public static void Main(string[] args)
        {
            Observable observable = new Observable();
            // Observer1 takes a subscription to the store
            Observer observer1 = new Observer("Observer 1");
            observable.Add(observer1);
            // Observer2 also subscribes to the store
            observable.Add(new Observer("Observer 2"));
            observable.Inventory++;
            // Observer1 unsubscribes and Observer3 subscribes to notifications.
            observable.Remove(observer1);
            observable.Add(new Observer("Observer 3"));
            observable.Inventory++;
            Console.ReadKey(true);
        }
    }
}
