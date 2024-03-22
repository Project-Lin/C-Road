namespace _14_結構體和類的不同
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(10,"檔案1");
            Student s2 = new Student(20, "檔案2");

            s2 = s1;
            s1.Name = "檔案3";
            s1.Age= 30;
            Console.WriteLine(s2.Name);
            Console.WriteLine(s2.Age);
        }
    }
    struct StudentSt
    {
        public string Name;
        public int Age;

        public StudentSt(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
