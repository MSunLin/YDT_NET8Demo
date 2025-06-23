using static System.Net.Mime.MediaTypeNames;

namespace _003_泛型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //动物   鸟   鹦鹉   家雀   
            IBaid parrot = new Parrot("小鹦鹉");
            parrot.Fly();
            Show(new Parrot("小鹦鹉"));

            Test1<Parrot> testc = new Test1<Parrot>();

        }

        public static void Show<T>(T t) 
            where T : IBaid
        {
            Console.WriteLine($"我是{t.Name}，我会飞");
            t.Fly();
        }


    }
}
