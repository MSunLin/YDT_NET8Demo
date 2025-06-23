using Microsoft.Extensions.Configuration;

namespace _002_配置组件
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1、读取json格式的系统配置
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("Appsettings.json");
            IConfigurationRoot config = configurationBuilder.Build();

            Console.WriteLine(config["AppSettings:AppName"]);
            Console.WriteLine(config["AppSettings:Logging:LogLevel:Default "]);
            #endregion



            Console.ReadKey();
        }
    }
}
