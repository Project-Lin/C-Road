namespace _21_資源訪問衝突
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StateObject stateObject = new StateObject();

            for (int i = 0; i < 100; i++)
            {
                Thread thread = new Thread(stateObject.ChangeState);
                thread.Start();
            }
        }
    }
}
