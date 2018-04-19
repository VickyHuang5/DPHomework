using System.Collections.Generic;

namespace CompositePattern
{
    /// <summary>
    /// 任天堂套餐
    /// </summary>
    public class NintendoCombo : AbstractComboProduct
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public NintendoCombo()
        {
            this.Products = new List<IPrice>
            {
                new NintendoSwitch(),
                new NintendoZelda()
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