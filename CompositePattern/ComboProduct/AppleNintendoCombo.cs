using System.Collections.Generic;

namespace CompositePattern
{
    /// <summary>
    /// ApplexNintendo套餐
    /// </summary>
    public class AppleNintendoCombo : AbstractComboProduct
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public AppleNintendoCombo()
        {
            this.Products = new List<IPrice>
            {
                new AppleCombo(),
                new NintendoCombo()
            };
        }

        /// <summary>
        /// 折扣
        /// </summary>
        protected override double Discount
        {
            get { return 1000; }
        }

        /// <summary>
        /// 取得套餐價格
        /// </summary>
        /// <returns>套餐價格</returns>
        public override double GetPrice()
        {
            return this.SumPrice() - this.Discount;
        }
    }
}