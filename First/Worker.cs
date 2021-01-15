
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.MyApp
{
    class Worker : Employeer, IWorker
    {
        string _work = "";
        public bool IsWorking {
            get
            {
                return _work.Length > 0;
            }
        }
        public Worker() : base() { }
        public Worker(string name, string surname, DateTime birthDate, Gender gender, float salary) :
            base(name, surname, birthDate, gender, salary)
        { }
        public string Work()
        {
            return _work;
        }
        public void stopWorking()
        {
            _work = "";
        }
        public void nextTask(string task)
        {
            if (IsWorking == false)
            {
                if (task.Length > 0)
                {
                    _work = task;
                }
                else
                    throw new Exception("New task is invalid!");
            }
            else
            {
                throw new Exception("I'm working now");
            }
        }
    }
}
