using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Client2: Iobserver
    {
        public string Name = "клиент коля";
        Iobservable store;
        public Client2(string name, Iobservable obs)
        {
            this.Name = name;
            store = obs;
            store.Addobserver(this);
        }
        public void Update(object ob)
        {
            StoreInfo storeInfo = (StoreInfo)ob;
            if (storeInfo.discount <10)
                Console.WriteLine("{0} получил меньще 10 %   {1}", Name, storeInfo.discount);
            else
                Console.WriteLine("скидка для {0} ", Name , storeInfo.discount);
        }
        public void StopStore()
        {
            store.RemoveObserver(this);
            store = null;
        }
    }
}
