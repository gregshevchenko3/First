using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.MyApp
{
    class Company : Department
    {
        List<Department> _departments;

        public List<Department> Departments
        {
            get => _departments;
        }
        public Company(string name, Manager director) : base(name, director) {
            _departments = new List<Department>();
        }
        public Company addDepartment(Department department)
        {
            _departments.Add(department);
            return this;
        }
        public Company removeDepartment(Department department)
        {
            _departments.Remove(department);
            return this;
        }
        public Company removeDepartment(Predicate<Department> predicate)
        {
            int index = _departments.FindIndex(predicate);
            if (index >= 0) {
                _departments.RemoveAt(index);
            }
            return this;
        }
        public override string ToString()
        {
            string departments_list = "";
            foreach (Department item in _departments)
            {
                departments_list += "______________________\n";
                departments_list += item.ToString();
                departments_list += "\n______________________\n";
            }
            return base.ToString() + departments_list;
        }
    }
}
