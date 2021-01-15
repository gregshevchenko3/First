using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        abstract class Vechicle
        {
            private string _model;
            private string _manufacturer;
            private float _weight;
            private int _power;

            public string Model
            {
                get
                {
                    return _model;
                }
                set
                {
                    if(value != null && value.Length >= 2)
                    {
                        _model = value;
                    }
                    else
                        throw new ArgumentException();
                }
            }
            public string Manufacturer
            {
                get
                {
                    return _manufacturer;
                }
                set
                {
                    if (value != null && value.Length >= 2)
                    {
                        _manufacturer = value;
                    }
                    else
                        throw new ArgumentException();
                }
            }
            public float Weight
            {
                get
                {
                    return _weight;
                }
                set
                {
                    if (value > 0)
                    {
                        _weight = value;
                    }
                    else
                        throw new ArgumentException();
                }
            }
            public int Power
            {
                get
                {
                    return _power;
                }
                set
                {
                    if (value > 0)
                    {
                        _power = value;
                    }
                    else
                        throw new ArgumentException();
                }
            }

            public abstract void move();
            public abstract void fillUp(int volume);
            public abstract void repair();
            public abstract void carryMaintenance();

            public virtual void Print(string object_name, int nesting_level = 0)
            {
                string s = "";
                for (int i = 0; i < nesting_level; i++)
                {
                    s += "\t";
                }
                
                Console.WriteLine($"\"{object_name}\": " + "{\n" + $"{s}\t\"Model\": \"{Model}\", \n" +
                    $"{s}\t\"Manufacturer\": \"{Manufacturer}\",\n" +
                    $"{s}\t\"Weight\": {Weight},\n" +
                    $"{s}\t\"Power\": {Power}\n{s}" + "}");
            }
        }
    }
}
