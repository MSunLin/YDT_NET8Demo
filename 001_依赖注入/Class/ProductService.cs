using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_依赖注入.Class
{
    internal class ProductService
    {
        public ProductRepository ProductRepository { get; set; }
        public ProductService(ProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }
        public void GetProduct()
        {
            ProductRepository.GetProduct();
            Console.WriteLine($"查询商品信息成功{this.GetHashCode()}");
        }
    }
}
