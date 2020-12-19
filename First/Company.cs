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
            private Employeer[] _workers;
            public Company()
            {
                _workers = new Employeer[0];
            }
            public Employeer getWorker(int index)
            {
                if (index < 0 || index >= _workers.Length)
                    throw new IndexOutOfRangeException("The number of worker isn't correct");
                return _workers[index];
            }
            public Company addWorker(Employeer employee)
            {
                Employeer[] tmp = new Employeer[_workers.Length + 1];
                Array.Copy(_workers, tmp, _workers.Length);
                tmp[_workers.Length] = employee;
                _workers = tmp;
                return this;
            }
            public Company removeWorker(Employeer employee)
            {
                _workers = _workers.Where(item => item != employee).ToArray();
                return this;
            }
            public override string ToString()
            {
                string res  = "[\n";
                foreach (var item in _workers)
                {
                    res += "\t{\n" +item.ToString() + "\t}\n";
                }
                res += "]";
                return res;
            }
        }
    }
}
