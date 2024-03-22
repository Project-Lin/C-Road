namespace _06_虛方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            boss.Move();

            Type1Enemy type1Enemy = new Type1Enemy();
            type1Enemy.Move();

            //可以用父類聲明
            Enemy a;

            //子類構造
            a= new Boss();

            //本質是敵人類  所以無法調用Boss類的方法
            a.skill();
            a.Move();


        }
    }
}
