using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ToString
{
    internal class Student
    {
        public int Age;

        public string Name;

        public Student(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            string result = $"Name:{Name} Age:{Age}";
            return result ;
        }
    }
}
