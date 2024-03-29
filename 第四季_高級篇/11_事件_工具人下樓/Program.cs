namespace _11_事件_工具人下樓
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LazyMan lazyMan = new LazyMan("小明");
            LazyMan lazyMan1 = new LazyMan("小華");

            ToolMan toolMan = new ToolMan("工具人");

            //訂閱事件 如果工具人出門 就執行懶人的方法
            toolMan.GoOutEvent += lazyMan.TakePackage;
            toolMan.GoOutEvent += lazyMan1.TakeFood;
            toolMan.GoOut();  //工具人工具人出門 幫懶人小明拿包裹 幫懶人小華拿食物
            //退訂事件 
            toolMan.GoOutEvent -= lazyMan1.TakeFood;
            toolMan.GoOut(); //工具人工具人出門 幫懶人小明拿包裹
        }
    }
}
