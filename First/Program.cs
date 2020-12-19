using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Human human = new Human();
                //Console.WriteLine(human.Name);

                //Human mulder = new Human("Fox", "Mulder", new DateTime(1975, 4, 12), Gender.MALE);
                //mulder.Show();

                Employeer mulder = new Employeer("Fox", "Mulder", new DateTime(1975, 4, 12), Gender.MALE, 12000.00f);
                Tutor tutor = new Tutor("John", "Doe", new DateTime(1981, 12, 10), Gender.MALE, 24000.00f, "Physics");

                Console.WriteLine("Create \"Company\" object & and add two workers");
                Company company = new Company();
                company.addWorker(mulder).addWorker(tutor);
                Console.WriteLine(company);

                Console.WriteLine("remove \"tutor\"");
                company.removeWorker(tutor);
                Console.WriteLine(company);

                Console.WriteLine("remove \"mulder\"");
                company.removeWorker(mulder);
                Console.WriteLine(company);

                Console.WriteLine("remove \"tutor\"");
                company.removeWorker(tutor);
                Console.WriteLine(company);
            }
        }
    }
    
}
