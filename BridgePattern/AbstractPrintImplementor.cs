namespace BridgePattern
{
    /// <summary>
    /// 抽象列印實作
    /// </summary>
    public abstract class AbstractPrintImplementor
    {
        /// <summary>
        /// 列印
        /// </summary>
        public abstract void Print();

        /// <summary>
        /// 開啟
        /// </summary>
        public abstract void Open();

        /// <summary>
        /// 關閉
        /// </summary>
        public abstract void Close();
    }
}