using System;

namespace StrategyPattern
{
    /// <summary>
    /// 全商品折扣
    /// </summary>
    public class DiscountForAllItems : IDiscount
    {
        /// <summary>
        /// 折扣%
        /// </summary>
        private double percentDiscount;

        /// <summary>
        /// 建構子
        /// </summary>
        public DiscountForAllItems()
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
            int discountAmount = Convert.ToInt16(Math.Floor(originalPrice * this.percentDiscount));
            return discountAmount;
        }

        /// <summary>
        /// 設定折扣條件
        /// </summary>
        /// <returns>折扣%</returns>
        public double SetCondition()
        {
            return this.percentDiscount = 0.2;
        }
    }
}