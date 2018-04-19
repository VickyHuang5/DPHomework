using System.Collections.Generic;

namespace CompositePattern
{
    /// <summary>
    /// Apple套餐
    /// </summary>
    public class AppleCombo : AbstractComboProduct
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public AppleCombo()
        {
            this.Products = new List<IPrice>
            {
                new AppleMacBookPro(),
                new AppleIPadAir(),
                new AppleWatch()
            };
        }

        /// <summary>
        /// 折扣
        /// </summary>
        protected override double Discount
        {
            get { return 0.9; }
        }

        /// <summary>
        /// 取得套餐價格
        /// </summary>
        /// <returns>套餐價格</returns>
        public override double GetPrice()
        {
            return this.Discount * this.SumPrice();
        }
    }
}