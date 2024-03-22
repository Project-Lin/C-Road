using System.Numerics;

namespace _03_面相對象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //使用類創建對象, c1就是對象名
            Customer c1 = new Customer();

            //聲明對象  (就像是int a  或是int[] b;
            Customer c2;
            //實例化對象 (賦值 a=10  或是 b=new int[4];
            c2 = new Customer();
            //實例化格式: new 類名();

            //實例化之後就可以使用類裡面的屬性或方法

            c1.age = 1;
            c1.name = "檔案";
            c1.address = "龍米路二段";
            c1.createTime = "2024年";

            c1.Show();

            Vehicle car = new Vehicle(); 
     
            car.Run();
            car.Stop();
            

            Vector3 v1 = new Vector3();
            v1.SetX(3.54f);
            v1.SetY(4.13f);
            v1.SetZ(5.21f);
            Console.WriteLine(v1.Length());

            


            




        }
    }
}
