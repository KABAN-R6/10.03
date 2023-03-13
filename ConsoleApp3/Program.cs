using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            
            Client client = new Client("клинт дима",store);
            
            Client2 client2 = new Client2("клиент коля", store);
            store.Market();

            
        }
    }
}
