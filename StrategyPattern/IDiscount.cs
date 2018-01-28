namespace StrategyPattern
{
    /// <summary>
    /// 折扣介面
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// 設定折扣條件
        /// </summary>
        /// <returns>條件</returns>
        double SetCondition();

        /// <summary>
        /// 計算折扣金額
        /// </summary>
        /// <param name="originalPrice">原價</param>
        /// <returns>折扣金額</returns>
        int CalculateDiscountAmount(int originalPrice);
    }
}