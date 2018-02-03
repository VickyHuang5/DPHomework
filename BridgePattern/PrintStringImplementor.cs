using System;

namespace BridgePattern
{
    /// <summary>
    /// 列印字串實作
    /// </summary>
    public class PrintStringImplementor : AbstractPrintImplementor
    {
        /// <summary>
        /// 輸出字串
        /// </summary>
        private string OutputString;

        /// <summary>
        /// 寬度
        /// </summary>
        private int Width;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="outputString">輸出字串</param>
        public PrintStringImplementor(string outputString)
        {
            this.OutputString = outputString;
            this.Width = this.OutputString.Length;
        }

        /// <summary>
        /// 複寫列印
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"|{this.OutputString}|");
        }
        
        /// <summary>
        /// 複寫開啟
        /// </summary>
        public override void Open()
        {
            this.PrintDividers();
        }

        /// <summary>
        /// 複寫關閉
        /// </summary>
        public override void Close()
        {
            this.PrintDividers();
        }

        /// <summary>
        /// 列印分隔線
        /// </summary>
        private void PrintDividers()
        {
            Console.Write("+");
            for (int i = 0; i < this.Width; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("+");
        }
    }
}