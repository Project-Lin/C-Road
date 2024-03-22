namespace _10_接口
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IFly fly;
            fly =new Bird();
            fly.Fly();
            fly.FlyAttack();

           
            fly = new Plane();
            fly.Fly();
            fly.FlyAttack();
        }
    }
}
