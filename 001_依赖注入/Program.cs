using _001_依赖注入.Class;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;

namespace _001_依赖注入
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01、
            //1、创建依赖注入容器
            ServiceCollection services = new ServiceCollection();

            //2、注册服务
            //services.AddTransient<ProductService>();
            //services.AddTransient<ProductRepository>();

            //services.AddSingleton<ProductService>();
            //services.AddSingleton<ProductRepository>();

            services.AddScoped<ProductService>();
            services.AddScoped<ProductRepository>();
            //3、获取对象，构造函数注入
            ServiceProvider sp = services.BuildServiceProvider();

            //注意：如果使用了Scoped，需用用创建作用域来获取服务实例，通过CreateScope方法
            //也可以通过using（ServiceProvider sp = services.BuildServiceProvider();）来创建作用域
            using (IServiceScope serviceScope = sp.CreateScope())
            {
                ProductService productService = serviceScope.ServiceProvider.GetRequiredService<ProductService>();
                productService.GetProduct();

                productService.GetProduct();
            }

                //4、使用服务
                //调用两次，验证瞬时服务的生命周期
                
            ProductService productService1 = sp.GetRequiredService<ProductService>();
            productService1.GetProduct();




            #endregion

            #region 02、依赖注入的生命周期
            /*  依赖注入有三个生命周期
             *  1、瞬时 / Transient，每次请求，都会创建一个新的实例
             *  一般用于
             *  2、范围 / Scoped，在指定的范围内，第一次请求时会创建一个实例重复请求时，会返回同一个实例
             *  用于事务、数据库连接、request请求
             *  3、单例 / Singleton，在整个程序生命周期，只会创建一次后续所有请求，都会返回同一个实例
             *  一般用于缓存数据的场景
             */
            #endregion





            Console.ReadKey();
        }
    }
}
