using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.MyApp 
{
    class Cashier : Employeer, IWorker
    {
        private bool _isWorking = true;
        private string _work;
        public bool IsWorking {
            get
            {
                return _isWorking;
            }
        }

        public string Work()
        {
            return _work;
        }
        public void stopWorking()
        {
            _isWorking = false;
        }
        public void nextTask(string task)
        {
            if(_isWorking == false)
            {
                if (task.Length > 0)
                {
                    _work = task;
                    _isWorking = true;
                }
                else
                    throw new Exception("New task is invalid!");
            } 
            else
            {
                throw new Exception("I'm working now");
            }
        }
        public Cashier():base()
        {

        }
        public Cashier(string name, string surname, DateTime birthDate, Gender gender, float salary) : 
            base(name, surname, birthDate, gender, salary)
        {

        }
    }
}
