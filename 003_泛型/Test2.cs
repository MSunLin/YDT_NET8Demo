using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_泛型
{
    internal class Test2<T>
    {
        public void MEthod1 (T t) { }

        public void MEthod2<U>(U u) where U : T
        {
            Console.WriteLine($"U的类型是{u.GetType().Name}，T的类型是{typeof(T).Name}");
        }   


    }
}
