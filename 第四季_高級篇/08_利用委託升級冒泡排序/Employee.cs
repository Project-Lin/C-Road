using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_利用委託升級冒泡排序
{
    internal class Employee
    {
        public string Name { get;private set; }
        public int Salary { get;private set; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public static bool Compare(Employee e1, Employee e2)
        {
            return e1.Salary > e2.Salary;
        }
    }
}
