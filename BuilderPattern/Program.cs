using System;

namespace BuilderPattern
{
    /// <summary>
    /// 電腦組裝
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 主程式
        /// </summary>
        /// <param name="args">執行參數</param>
        private static void Main(string[] args)
        {
            Director director = new Director();
            Builder AsusComputer = new AsusComputerBuilder();
            Builder HpComputer = new HpComputerBuilder();
            if (args[0].ToUpperInvariant() == "ASUS")
            {
                director.Construct(AsusComputer, args);
                Computer asusComputer = AsusComputer.GetComputer();
                asusComputer.Show();
            }
            else if (args[0].ToUpperInvariant() == "HP")
            {
                director.Construct(HpComputer, args);
                Computer hpComputer = HpComputer.GetComputer();
                hpComputer.Show();
            }
            else
            {
                Console.WriteLine("請輸入品牌，再輸入規格(CPU型號,RAM大小,HD大小,顯示卡型號)，例：Asus intel-core-i7 8 500 GV-N710D5-2GL");
            }

            Console.Read();
        }
    }
}