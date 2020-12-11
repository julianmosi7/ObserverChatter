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
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{observer.ClientName} attached");
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
