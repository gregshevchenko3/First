using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.MyApp
{
    class Director : Worker, IManager
    {
        private string _work;
        private bool _isWorking;
        public List<IWorker> listWorkers {
            get;
            set;
        }

        public bool IsWorking { get { return _isWorking; } }
        public void control()
        {
            Console.WriteLine("I control the process");
        }

        public void organize()
        {
            Console.WriteLine("I organize the workflow");
        }

        public override string ToString()
        {
            string result = $"Director:\n {base.ToString()}\n\n\n =============================== WORKERS: ==========================";
            if (listWorkers.Count > 0)
            {
                foreach (Worker worker in listWorkers)
                {
                    Employeer emp = worker;
                    result += $"\n\n";
                    result += emp.ToString();
                }
            }
            result += "\n========================================================================== \n\n\n";
            return result;
        }
        public Director() : base() { }
        public Director(string name, string surname, DateTime birthDate, Gender gender, float salary) :
            base(name, surname, birthDate, gender, salary)
        {
            listWorkers = new List<IWorker>();
        }
    }
}
