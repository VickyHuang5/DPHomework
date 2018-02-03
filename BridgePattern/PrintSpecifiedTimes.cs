namespace BridgePattern
{
    /// <summary>
    /// 列印指定次數
    /// </summary>
    public class PrintSpecifiedTimes : PrintWord
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="implementor">實作</param>
        public PrintSpecifiedTimes(AbstractPrintImplementor implementor) : base(implementor)
        {
        }

        /// <summary>
        /// 反覆列印
        /// </summary>
        /// <param name="times">次數</param>
        public void PrintMultipleTimes(int times)
        {
            this.Open();
            for (int i = 0; i < times; i++)
            {
                this.Print();
            }

            this.Close();
        }
    }
}