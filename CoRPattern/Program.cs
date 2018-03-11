using System;

namespace CoRPattern
{
    /// <summary>
    /// 主程式
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 主程式
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("請輸入身分證號");
            string idNumber = Console.ReadLine();
            IdNumberCheckService idNumberCheckService = new IdNumberCheckService();
            string result = idNumberCheckService.CheckIdNumber(idNumber) ? "正確" : "不正確";
            Console.WriteLine($"身分證號{result}");
            Console.ReadKey();
        }
    }
}