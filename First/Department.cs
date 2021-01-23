using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        class Department
        {
            private string _name;
            private Manager _manager;
            
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
            public Manager Manager
            {
                get
                {
                    return _manager;
                }
            }
            public Department(string name, Manager manager)
            {
                Name = name;
                _manager = manager;
            }
            public IWorker getWorker(int index)
            {
                return Workers[index];
            }
            public Department addWorker(IWorker worker)
            {
                this._manager.listWorkers.Add(worker);
                return this;
            }
            public Department removeWorker(Predicate<IWorker> predicate)
            {
                int index = Workers.FindIndex(predicate);
                if(index >= 0)
                    Workers.RemoveAt(index);
                return this;
            }
            public Department removeWorker(IWorker worker)
            {
                Workers.Remove(worker);
                return this;
            }
            public List<IWorker> Workers
            {
                get
                {
                    return _manager.listWorkers;
                }
            }
            public override string ToString()
            {
                return $"Department: {Name}\n; Head of Department: " + Manager.ToString();
            }
        }
    }
}
