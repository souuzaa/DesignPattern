using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public interface IObservable
    {
        void Add(Observer observer);
        void Remove(Observer observer);
        void Notify();
    }
}
