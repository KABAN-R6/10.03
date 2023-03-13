using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Store : Iobservable
    {
        StoreInfo sinfo;

        List<Iobserver> observers;
        public Store()
        {
            observers = new List<Iobserver>();
            sinfo = new StoreInfo();
        }
        public void Addobserver(Iobserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Iobserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (Iobserver o in observers)
            {
                o.Update(sinfo);
            }
        }
        public void Market()
        {
            Random rnd = new Random();
            sinfo.discount = rnd.Next(1, 50);
            NotifyObserver();
        }
    }
}
