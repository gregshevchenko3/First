using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        class Employeer : Human
        {
            private float _salary;
            public float Salary
            {
                get
                {
                    return _salary;
                }
                set
                {
                    if (value >= 0 && value <= float.MaxValue)
                    {
                        _salary = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Salari is invalid");
                    }
                }
            }
            public Employeer():base()
            {
                _salary = 0.0f;
            }
            public Employeer(string name, string surname, DateTime birthDate, Gender gender, float salary) 
                : base(name, surname, birthDate, gender)
            {
                Salary = salary;
            }
            override public void Show()
            {
                base.Show();
                Console.WriteLine($"\tSalary: {Salary}$");
            }
            public override string ToString()
            {
                return base.ToString() + $"\tSalary: {Salary}$\n";
            }
        }
    }
}
