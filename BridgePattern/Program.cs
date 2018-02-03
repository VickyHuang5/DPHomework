using System;

namespace BridgePattern
{
    /// <summary>
    /// 主程式
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 主程式
        /// </summary>
        /// <param name="args">執行參數</param>
        private static void Main(string[] args)
        {
            PrintWord print1 = new PrintWord(new PrintStringImplementor("Hello World!"));
            print1.Show();

            PrintWord print2 = new PrintSpecifiedTimes(new PrintStringImplementor(" Hello Taiwan!"));
            print2.Show();

            PrintSpecifiedTimes print3 = new PrintSpecifiedTimes(new PrintStringImplementor(" Hello Taiwan!"));
            print3.PrintMultipleTimes(10);

            PrintRandomTimes print4 = new PrintRandomTimes(new PrintStringImplementor(" Hello Taiwan!"));
            print4.RandomPrint();

            PrintRandomTimes print5 = new PrintRandomTimes(new PrintFileImplementor(" Hello Taiwan!"));
            print5.RandomPrint();

            Console.ReadKey();
        }
    }
}