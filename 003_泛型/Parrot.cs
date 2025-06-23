using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_泛型
{
    /// <summary>
    /// 鹦鹉
    /// </summary>
    public class Parrot : IBaid
    {
        public string Name { get; }
        public Parrot(string Name)
        {
            this.Name = Name;
        }

        public void Fly()
        {
            Console.WriteLine($"我是{Name}，我会飞");
        }
    }
}
