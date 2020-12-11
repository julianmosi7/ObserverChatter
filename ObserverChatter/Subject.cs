using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverChatter
{
    public abstract class Subject
    {
        List<IObserver> observers = new List<IObserver>();

        public int NrObservers { get; }
        public string Topic { get; set; }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
            observers.ForEach(x => x.ClientAttached(observer.ClientName));
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
            observers.ForEach(x => x.ClientDetached(observer.ClientName));
        }

        public void Notify(string name, string msg)
        {
            observers.ForEach(x => x.Update(name, msg));
        }
    }
}
