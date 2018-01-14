namespace BuilderPattern
{
    /// <summary>
    /// 惠普電腦建造器
    /// </summary>
    internal class HpComputerBuilder : Builder
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public HpComputerBuilder()
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
            this.product.Add($"Mother Board:HP");
            return this;
        }
    }
}