using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication1
{
    /// <summary>
    /// 主程式
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 主程式
        /// </summary>
        /// <param name="args">程式參數</param>
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        /// <summary>
        /// 建立WebHost
        /// </summary>
        /// <param name="args">程式參數</param>
        /// <returns>WebHost</returns>
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}