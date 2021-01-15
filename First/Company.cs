using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        class Company
        {
            private string _name;
            private Director _director;
            
            public String Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }
            public Director Director
            {
                get
                {
                    return _director;
                }
            }
            public Company(string name, Director director)
            {
                Name = name;
                _director = director;
            }
            public IWorker getWorker(int index)
            {
                return Workers[index];
            }
            public Company addWorker(IWorker worker)
            {
                this._director.listWorkers.Add(worker);
                return this;
            }
            public Company removeWorker(Predicate<IWorker> predicate)
            {
                int index = Workers.FindIndex(predicate);
                if(index >= 0)
                    Workers.RemoveAt(index);
                return this;
            }
            public Company removeWorker(IWorker worker)
            {
                Workers.Remove(worker);
                return this;
            }
            public List<IWorker> Workers
            {
                get
                {
                    return _director.listWorkers;
                }
            }
            public override string ToString()
            {
                return $"Company: {Name}\n" + Director.ToString();
            }
        }
    }
}
