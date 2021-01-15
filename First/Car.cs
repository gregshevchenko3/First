using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        enum Colors
        {
            RED,
            BLUE,
            GREEN,
            ORANGE,
        }
        class Car : Vechicle
        {
            private Colors _color;
            public Colors Color
            {
                get
                {
                    return _color;
                }
            }
            public Car()
            {
                Model = "BAЗ 2109";
                Manufacturer = "Mersedes Benz";
                Weight = 1350f;
                Power = 95;
                _color = Colors.ORANGE;
            }
            public Car(string model, string man, float weight, int power, Colors color)
            {
                Model = model;
                Manufacturer = man;
                Weight = weight;
                Power = power;
                _color = color;
            }
            public override void carryMaintenance()
            {
                throw new NotImplementedException();
            }

            public override void fillUp(int volume)
            {
                throw new NotImplementedException();
            }

            public override void move()
            {
                throw new NotImplementedException();
            }

            public override void repair()
            {
                throw new NotImplementedException();
            }
            public override void Print(string object_name, int nesting_level = 0)
            {
                string s = "";
                for (int i = 0; i < nesting_level; i++)
                {
                    s += "\t";
                }

                Console.WriteLine($"\"{object_name}\": " + "{\n" + $"{s}\t\"Model\": \"{Model}\", \n" +
                    $"{s}\t\"Manufacturer\": \"{Manufacturer}\",\n" +
                    $"{s}\t\"Weight\": {Weight},\n" +
                    $"{s}\t\"Power\": {Power},\n" +
                    $"{s}\t\"Color\": \"{Color}\"\n{s}" + "}");
            }

        }
    }
}
