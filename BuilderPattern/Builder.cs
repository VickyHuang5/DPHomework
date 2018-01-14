namespace BuilderPattern
{
    /// <summary>
    /// 建造器
    /// </summary>
    internal abstract class Builder
    {
        /// <summary>
        /// 產品
        /// </summary>
        protected Computer product = new Computer();

        /// <summary>
        /// 加入RAM
        /// </summary>
        /// <param name="size">大小</param>
        /// <returns>建造器</returns>
        public Builder AddRam(int size)
        {
            this.product.Add($"RAM:{size}G");
            return this;
        }

        /// <summary>
        /// 加入CPU
        /// </summary>
        /// <param name="model">型號</param>
        /// <returns>建造器</returns>
        public Builder AddCpu(string model)
        {
            this.product.Add($"CPU:{model}");
            return this;
        }

        /// <summary>
        /// 加入硬碟
        /// </summary>
        /// <param name="size">大小</param>
        /// <returns>建造器</returns>
        public Builder AddHd(int size)
        {
            this.product.Add($"HD:{size}G");
            return this;
        }

        /// <summary>
        /// 加入顯示卡
        /// </summary>
        /// <param name="model">型號</param>
        /// <returns>建造器</returns>
        public Builder AddGraphicsCard(string model)
        {
            this.product.Add($"Graphics Card:{model}");
            return this;
        }

        /// <summary>
        /// 取得電腦
        /// </summary>
        /// <returns>電腦</returns>
        public abstract Computer GetComputer();
    }
}