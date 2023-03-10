using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class ConcreteObservable : Iobservable
    {
        private List<Iobserver> observers;
        public ConcreteObservable()
        {
            observers = new List<Iobserver>();
        }
        public void Addobserver(Iobserver o)
        {
            observers.Add(o);
        }
        public void RemoveObserver(Iobserver o)
        {
            observers.Remove(o);
        }
        public void  NotifyObserver()
        {
            foreach (Iobserver observer in observers)
                observer.Update();
        }
    }
}
