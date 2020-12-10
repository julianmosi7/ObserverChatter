using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverChatter
{
    abstract class Subject
    {
        List<IObserver> observers = new List<IObserver>();

        public int NrObservers { get; }
        public string Topic { get; set; }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify(string name, string msg)
        {
            observers.ForEach(x => x.Update(name, msg));
        }
    }
}
