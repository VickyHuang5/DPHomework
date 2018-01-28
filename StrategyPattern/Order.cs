namespace StrategyPattern
{
    /// <summary>
    /// 訂單
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 訂單編號
        /// </summary>
        protected string OrderId;

        /// <summary>
        /// 原價
        /// </summary>
        protected int OriginalPrice;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="orderId">訂單編號</param>
        /// <param name="originalPrice">原價</param>
        public Order(string orderId, int originalPrice)
        {
            this.OrderId = orderId;
            this.OriginalPrice = originalPrice;
        }

        /// <summary>
        /// 計算折扣
        /// </summary>
        /// <param name="discount">折扣</param>
        /// <returns>折扣後金額</returns>
        public int CalculateDiscount(IDiscount discount)
        {
            int checkoutAmount = this.OriginalPrice;
            checkoutAmount = this.OriginalPrice - discount.CalculateDiscountAmount(this.OriginalPrice);
            return checkoutAmount;
        }
    }
}