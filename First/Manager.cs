using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.MyApp
{
    class Manager : Employeer, IManager
    {
        public List<IWorker> listWorkers {
            get;
            set;
        }

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
                foreach (Employeer worker in listWorkers)
                {
                    result += $"\n\n";
                    result += worker.ToString();
                }
            }
            result += "\n========================================================================== \n\n\n";
            return result;
        }
        public Manager() : base() { }
        public Manager(string name, string surname, DateTime birthDate, Gender gender, float salary) :
            base(name, surname, birthDate, gender, salary)
        {
            listWorkers = new List<IWorker>();
        }
    }
}
