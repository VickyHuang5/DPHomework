using System.Collections.Generic;
using System.Linq;

namespace CompositePattern
{
    /// <summary>
    /// 組合商品抽象類別
    /// </summary>
    public abstract class AbstractComboProduct : IPrice
    {
        /// <summary>
        /// 商品清單
        /// </summary>
        protected List<IPrice> Products;

        /// <summary>
        /// 折扣
        /// </summary>
        protected abstract double Discount { get; }

        /// <summary>
        /// 取得套餐價格價格
        /// </summary>
        /// <returns>套餐價格</returns>
        public abstract double GetPrice();

        /// <summary>
        /// 加總商品清單的價格
        /// </summary>
        /// <returns>價格總和</returns>
        public double SumPrice()
        {
            return this.Products.Sum(product => product.GetPrice());
        }
    }
}