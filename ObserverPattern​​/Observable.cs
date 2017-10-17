using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class Observable : IObservable
    {
        private List<Observer> list = new List<Observer>();
        public void Add(Observer observer)
        {
            list.Add(observer);
        }

        public void Remove(Observer observer)
        {
            list.Remove(observer); 
        }

        public void Notify()
        {
            list.ForEach(x => x.Update());
        }

        private int _inventory;
        public int Inventory
        {
            get
            {
                return _inventory;
            }
            set
            {
            // Just to make sure that if there is an increase in inventory, then we are notifying the observers.
            if (value > _inventory)
                    Notify();
             _inventory = value;
            }
        }
    }
}
