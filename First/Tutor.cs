using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        sealed class Tutor : Employeer
        {
            private string _specialty;
            public string Specialty
            {
                get
                {
                    return _specialty;
                }
                set
                {
                    if (value.Length > 0)
                        _specialty = value;
                    else
                        throw new ArgumentException("Member 'Spetialty' is invalid");
                }
            }
            public Tutor() : base()
            {

            }
            public Tutor(string name, string surname, DateTime birthDate, Gender gender, float salary, string specialty) 
                : base(name, surname, birthDate, gender, salary)
            {
                Specialty = specialty;
            }
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"\tSpetialty: {Specialty}");
            }
            public override string ToString()
            {
                return base.ToString() + $"\tSpetialty: {Specialty}\n";
            }
        }
    }
}
