namespace StrategyPattern
{
    /// <summary>
    /// 滿額折
    /// </summary>
    public class FullDiscount : IDiscount
    {
        /// <summary>
        /// 滿額門檻
        /// </summary>
        private double fullAmount;

        /// <summary>
        /// 建構子
        /// </summary>
        public FullDiscount()
        {
            this.SetCondition();
        }

        /// <summary>
        /// 計算折扣金額
        /// </summary>
        /// <param name="originalPrice">原價</param>
        /// <returns>折扣金額</returns>
        public int CalculateDiscountAmount(int originalPrice)
        {
            int discountAmount = 0;
            if (originalPrice >= this.fullAmount)
            {
                discountAmount = (int)(originalPrice / this.fullAmount) * 100;
            }

            return discountAmount;
        }

        /// <summary>
        /// 設定折扣條件
        /// </summary>
        /// <returns>滿額條件</returns>
        public double SetCondition()
        {
            return this.fullAmount = 1000;
        }
    }
}