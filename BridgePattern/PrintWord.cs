namespace BridgePattern
{
    /// <summary>
    /// 列印文件
    /// </summary>
    public class PrintWord
    {
        /// <summary>
        /// 實作
        /// </summary>
        private AbstractPrintImplementor Implementor;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="implementor">實作</param>
        public PrintWord(AbstractPrintImplementor implementor)
        {
            this.Implementor = implementor;
        }

        /// <summary>
        /// 列印
        /// </summary>
        public void Print()
        {
            this.Implementor.Print();
        }

        /// <summary>
        /// 開啟
        /// </summary>
        public void Open()
        {
            this.Implementor.Open();
        }

        /// <summary>
        /// 關閉
        /// </summary>
        public void Close()
        {
            this.Implementor.Close();
        }

        /// <summary>
        /// 顯示
        /// </summary>
        public void Show()
        {
            this.Open();
            this.Print();
            this.Close();
        }
    }
}