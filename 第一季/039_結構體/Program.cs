using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_結構體
{
    class Program
    {
        struct StudentInfo
        {
            public int age;
            public string name;
            public int grade;
            public int id;

        }
        struct Position
        {
            public double X;
            public double Y;
            public double Z;

            public void PrintPosition()
            {
                Console.WriteLine(X + "," + Y + "," + Z);
            }
        }

        struct Name
        {
            public string firstname;
            public string lastname;

            public void Allname()
            {
                Console.WriteLine(firstname + "," + lastname);
            }
        }

        struct Vector3
        {
            public double X;
            public double Y;
            public double Z;
            public double Distance()
            {
                double temp = X * X + Y * Y + Z * Z;
                return Math.Sqrt(temp);

            }
        }

            

            static void Main(string[] args)
            {
                //結構體和int string 使用方式一樣
                StudentInfo student1;
                student1.age = 10;
                student1.name = "檔案";
                student1.grade = 2;
                student1.id = 104238;


                StudentInfo[] students = new StudentInfo[10];
                students[0].age = 20;
                Console.WriteLine(students[0].age);

                Position p1;
                p1.X = 1;
                p1.Y = 10;
                p1.Z = 3;

                p1.PrintPosition();

                Name name1;
                name1.firstname = "HongYu";
                name1.lastname = "Lin";

                name1.Allname();


            Vector3 V1;
            V1.X = 2;
            V1.Y = 3;
            V1.Z = 10;
            Console.WriteLine(V1.Distance());



            }
        }
    
}
