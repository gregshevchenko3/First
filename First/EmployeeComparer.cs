using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.MyApp
{
    class EmployeeComparer
    {
        public static int CompareByNameASC(Employeer a, Employeer b)
        {
            return a.Name.CompareTo(b.Name);
        }
        public static int CompareByNameDESC(Employeer a, Employeer b)
        {
            return -a.Name.CompareTo(b.Name);
        }
        public static int CompareBySurnameASC(Employeer a, Employeer b)
        {
            return a.Surname.CompareTo(b.Surname);
        }
        public static int CompareBySurnameDESC(Employeer a, Employeer b)
        {
            return -a.Surname.CompareTo(b.Surname);
        }
        public static int CompareBySalaryASC(Employeer a, Employeer b)
        {
            return a.Salary.CompareTo(b.Salary);
        }
        public static int CompareBySalaryDESC(Employeer a, Employeer b)
        {
            return -a.Salary.CompareTo(b.Salary);
        }
        public static int CompareByBirthDateASC(Employeer a, Employeer b)
        {
            return a.BirthDate.CompareTo(b.BirthDate);
        }
        public static int CompareByBirthDateDESC(Employeer a, Employeer b)
        {
            return a.BirthDate.CompareTo(b.BirthDate);
        }
    }
}
