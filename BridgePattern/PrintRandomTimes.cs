using System;

namespace BridgePattern
{
    /// <summary>
    /// 列印隨機次數
    /// </summary>
    public class PrintRandomTimes : PrintWord
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="implementor">實作</param>
        public PrintRandomTimes(AbstractPrintImplementor implementor) : base(implementor)
        {
        }

        /// <summary>
        /// 隨機列印
        /// </summary>
        public void RandomPrint()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int randomTimes = random.Next(50);
            Console.WriteLine($"隨機列印{randomTimes}次");
            this.Open();
            for (int i = 0; i < randomTimes; i++)
            {
                this.Print();
            }

            this.Close();
        }
    }
}