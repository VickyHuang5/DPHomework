namespace BuilderPattern
{
    /// <summary>
    /// 華碩電腦建造器
    /// </summary>
    internal class AsusComputerBuilder : Builder
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public AsusComputerBuilder()
        {
            this.AddMb();
        }

        /// <summary>
        /// 複寫取得電腦
        /// </summary>
        /// <returns>電腦</returns>
        public override Computer GetComputer()
        {
            return this.product;
        }

        /// <summary>
        /// 加入主機板
        /// </summary>
        /// <returns>電腦建造器</returns>
        private Builder AddMb()
        {
            this.product.Add($"Mother Board:Asus");
            return this;
        }
    }
}