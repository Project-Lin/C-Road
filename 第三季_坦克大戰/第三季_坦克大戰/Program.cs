namespace 第三季_坦克大戰
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Father f = new Father();

            //tips:錯誤時可以用alt+enter調出提示

            //類 的 強制類型轉換
            //子類可以轉換成父類 但是父類不能轉換成子類
            Son s = (Son)f;
            s= f as Son;

            
            Son s1 = new Son();
            Father f1 =new Father();
            s1 = (Son)f1;
=======
            Console.WriteLine("Hello, World!");
            Console.WriteLine(123);
            Console.WriteLine();
>>>>>>> Stashed changes
        }


    }
    class Father
    {
        
    }
    class Son:Father
    {
        public void name()
        {
            Console.WriteLine("123");
        }   
    }
}
