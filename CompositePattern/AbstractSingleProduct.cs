namespace CompositePattern
{
    /// <summary>
    /// 單一商品抽象類別
    /// </summary>
    public abstract class AbstractSingleProduct : IPrice
    {
        /// <summary>
        /// 價格
        /// </summary>
        protected abstract double Price { get; }

        /// <summary>
        /// 取得價格
        /// </summary>
        /// <returns>價格</returns>
        public double GetPrice()
        {
            return this.Price;
        }
    }
}