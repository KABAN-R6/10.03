namespace ConsoleApp3
{
    interface Iobservable
    {
        void Addobserver(Iobserver o);
        void RemoveObserver(Iobserver o);
        void NotifyObserver();

    }
}
