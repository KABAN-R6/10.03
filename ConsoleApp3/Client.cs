using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Client : Iobserver
    {
        public string Name = "клиент дима";
        Iobservable store;
        public Client (string name,Iobservable obs)
        {
            this.Name = name;
            store = obs;
            store.Addobserver(this);
        }
        public void Update(object ob)
        {
            StoreInfo storeInfo = (StoreInfo)ob;
            if (storeInfo.discount > 30)
                Console.WriteLine("{0} получил скидку больще 30 % {1}", Name, storeInfo.discount) ;
            else
                Console.WriteLine("скидка {0}  {1}", Name  ,storeInfo.discount);
        }
        public void StopStore()
        {
            store.RemoveObserver(this);
            store = null;
        }
    }
}
