using Karambolo.Extensions.Logging.File;
using Microsoft.Extensions.Logging;
namespace _004_日志
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 01、从控制台输出日志
            //ILoggerFactory loggerFactory = LoggerFactory.Create(
            //    budder => budder.AddConsole()
            //    );
            //ILogger<Program> logger = loggerFactory.CreateLogger<Program>();
            //logger.LogInformation("Hello, World!");
            #endregion
            #region 2、文件日志输出
            {
                //// 1、创建日志 Hello, YDT_NET8_Logss!

                //// 2、创建日志对象ILogger
                //ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
                //    // 2.2、配置控制台日志
                //    builder.AddConsole();
                //    // 2.1、配置文件日志
                //    builder.AddFile(options => {
                //        // 1、配置文件根目录
                //        options.RootPath = AppContext.BaseDirectory;
                //        // 2、配置文件路径
                //        options.Files = new[] {
                //             new LogFileOptions{
                //                 Path ="logs/log.txt"
                //             }
                //         };
                //    });
                //});
                //// 2.2、创建ILogger接口
                //ILogger<Program> logger = loggerFactory.CreateLogger<Program>();

                //// 2.3、输出日志
                //logger.LogInformation("Hello, YDT_NET8_Logss!");

                //Console.ReadKey();
            }
            #endregion

            #region 02、日志保存到本地文件

            //ILoggerFactory loggerFactory = LoggerFactory.Create(
            //        builder =>
            //        {
            //            builder.AddConsole();
            //            builder.AddFile(
            //                options =>
            //                {
            //                    options.RootPath = AppContext.BaseDirectory; // 设置日志文件的根目录

            //                    options.Files = new[] {
            //                        new LogFileOptions{ Path = "logs/log.txt" }
            //                    };
            //                }
            //                );
            //        }
            //    );

            //ILogger<Program> logger = loggerFactory.CreateLogger<Program>();
            //logger.LogInformation("Hello, World!");
            ////Console.ReadKey();
            //logger.LogError("Hello, World!");
            ////Thread.Sleep(1000);
            //Console.ReadKey();
            #endregion

            #region 3、自定义日志输出——到MySql数据库



            #endregion
        }
    }
}
