using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_依赖注入.Class
{
    internal class ProductRepository
    {
        public void GetProduct()
        {
            Console.WriteLine("查询商品仓储成功");
        }
        
    }
}
