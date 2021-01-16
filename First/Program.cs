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

                Worker mulder = new Worker("Fox", "Mulder", new DateTime(1975, 4, 12), Gender.MALE, 12000.00f);
                Worker outlaw = new Worker("Jayne", "Cobb", new DateTime(1972, 1, 21), Gender.MALE, 24000.00f);

                Company comp = new Company("Serenity", new Director("Malcolm", "Reynolds", new DateTime(1970, 07, 21), Gender.MALE, 84000.00f));
                Console.WriteLine(comp);
                comp.addWorker(mulder).addWorker(outlaw);
                Console.WriteLine(comp);

                Console.WriteLine("Remove \"mulder\" \n");
                comp.removeWorker(mulder);
                Console.WriteLine(comp);

                Console.WriteLine("Remove \"Jayne Cobb\" \n");
                comp.removeWorker((worker) => {
                    Worker w = (Worker)worker;
                    return w.Name == "Jayne" && w.Surname == "Cobb";
                });
                Console.WriteLine(comp);

                Console.WriteLine("Create departments");
                Department Criminals = new Department("Outlaws",
                    new Director("Mark", "Sheppard", new DateTime(1977, 3, 3), Gender.MALE, 120000.00f)
                    ).addWorker(outlaw).addWorker(
                    new Worker("Zoe", "Washburne", new DateTime(1970, 9, 9), Gender.FEMALE, 24000.00f));
                comp.addDepartment(Criminals).addDepartment(
                        new Department("Other", new Director("Derrial", "Book", new DateTime(1965, 12, 12), Gender.MALE, 500.00f))
                        .addWorker(new Worker("Simon", "Tam", new DateTime(1985, 10, 10), Gender.MALE, 750.00f))
                        .addWorker(new Worker("River", "Tam", new DateTime(1988, 7, 24), Gender.MALE, 750.00f))
                    );
                Console.WriteLine(comp);

                Car zaporozhets = new Car();
                zaporozhets.Print("zaporozhets");
                Point2D point = new Point2D();
                Point2D point2 = new Point2D(100, 100, Colors.BLUE);
                ++point;
                point++;
                Console.WriteLine(point);
                Console.WriteLine(-point);
                Console.WriteLine(point + point2);


                point *= point2;
                point = point - point2;
                Console.WriteLine(point);

                point *= 3;
                point = 10 * point;
                Console.WriteLine(point);


                Console.WriteLine();
                Console.WriteLine(point/point2);
            }
        }
    }
    
}
