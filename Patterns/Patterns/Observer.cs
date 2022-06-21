using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    interface IObserver
    {
        bool Update(string l);
    }
    interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void Notify();
    }

    class Prod : IObservable
    {
        private List<IObserver> observers;
        private string language;
        public Prod(string l)
        {
            language = l;
            observers = new List<IObserver>();
        }
        public void ChangeLang(string l)
        {
            language = l;
            Notify();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
        public void Notify()
        {
            foreach (IObserver o in observers.ToList())
                o.Update(language);
        }
    }
    class WholeChanges : IObserver
    {
        private IObservable lg;
        public WholeChanges(IObservable obj)
        {
            lg = obj;
            obj.AddObserver(this);
        }
        public bool Update(string l)
        {
            if (l == "Ukr")
            {
                lg.RemoveObserver(this);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
