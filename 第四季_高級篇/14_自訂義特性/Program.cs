namespace _14_自訂義特性
{
    //使用自訂義特性
    [Information("檔案1", "v1.0", "這是一個自訂義特性")]
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Program);

            //判斷是否有特性
            bool result = type.IsDefined(typeof(InformationAttribute), false);
            Console.WriteLine(result); //True

            //獲取特性
            object[] objs = type.GetCustomAttributes(false);
            foreach (var item in objs)
            {
                InformationAttribute info = item as InformationAttribute;
                if (info != null)
                {
                    Console.WriteLine(info.Name);
                    Console.WriteLine(info.Version);
                    Console.WriteLine(info.Description);
                }
            }
        }
    }
}
