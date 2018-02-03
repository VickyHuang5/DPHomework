using System;
using System.IO;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// 列印檔案實作
    /// </summary>
    public class PrintFileImplementor : AbstractPrintImplementor
    {
        /// <summary>
        /// 輸出字串
        /// </summary>
        private string OutputString;

        /// <summary>
        /// 檔案
        /// </summary>
        private FileStream FileStream;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="outputString">輸出字串</param>
        public PrintFileImplementor(string outputString)
        {
            this.OutputString = outputString;
        }

        /// <summary>
        /// 複寫列印
        /// </summary>
        public override void Print()
        {
            byte[] output = new UTF8Encoding(true).GetBytes($"|{this.OutputString}|\r\n");
            this.FileStream.Write(output, 0, output.Length);
        }
        
        /// <summary>
        /// 複寫開啟
        /// </summary>
        public override void Open()
        {
            string path = Path.GetTempFileName();
            Console.WriteLine(path);
            this.FileStream = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None);
        }

        /// <summary>
        /// 複寫關閉
        /// </summary>
        public override void Close()
        {
            this.FileStream.Flush();
            this.FileStream.Dispose();
        }
    }
}