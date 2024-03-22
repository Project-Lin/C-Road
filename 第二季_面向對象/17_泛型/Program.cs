namespace _17_泛型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClassA<int> a=new ClassA<int>(1,2);
            //Console.WriteLine(a.GetSum()) ;

            //ClassA<double> b=new ClassA<double>(1.3,2.5);
            //Console.WriteLine(b.GetSum()) ;


            Console.WriteLine(GetSum<double>(1.3,54.2));

        }
        public static T GetSum<T>(T a , T b)
        {
            dynamic nub1 = a;
            dynamic nub2 = b;
            
            return (T)(nub1+nub2);
        }

        class ClassA<T>
        {
            private T a;
            private T b;

            public ClassA(T a, T b)
            {
                this.a = a;
                this.b = b;
            }

            public T GetSum()
            {
                dynamic a= this.a;
                dynamic b= this.b;
                return a+b;
            }
        }
    }
}
