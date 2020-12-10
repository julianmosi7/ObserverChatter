namespace ObserverChatter
{
    public interface IObserver
    {
        string ClientName { get; }

        void ClientAttached(string name);
        void ClientDetached(string name);
        void Update(string name, string msg);
    }
}